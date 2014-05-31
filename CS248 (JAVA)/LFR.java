import java.io.*;
import java.util.*;

class LFR
{
	public static void main(String [] args) throws IOException
	{
		String infilename;
		Scanner kbd = new Scanner(System.in);
		Scanner file;
		int number;
		Queue commands, customers, toa, tos;
		restaurant r, c, a, s;
		int B = 0;
		int tw = 0;

		System.out.println("");
		System.out.println(" ***Welcome to the LaFood Restaurant Simulator*** ");
		System.out.println("");
		System.out.println("Please enter the name of your data file: ");
		infilename = kbd.nextLine(); //Files in Data File Put Into String
		System.out.println("");

		file = new Scanner(new FileReader(infilename));
		number = file.nextInt(); //Number of Lines in File
		file.nextLine();

		customers = new QueueArray(number); //Customer Queue
		commands = new QueueArray(number); //Command Queue
		toa = new QueueArray(number); //Time of Arrival Queue
		tos = new QueueArray(number); //Time of Seating Queue

		for(int i=0; i<number; i++)
			commands.enqueue(new restaurant(file));


		while (!commands.isEmpty())
		{
			r = (restaurant)commands.dequeue();

			if (r.getLetter()=='A') //Arrival of A Party
			{
				System.out.println("Please wait at the bar,");
				System.out.println("\tparty "+r.getName()+" of "+r.getNumber()+" people. (time = "+r.getTime()+" hours)");
				customers.enqueue(r);
			}
			else if (r.getLetter()=='T') //Table Opens Up
			{
				B++;
				c = (restaurant)customers.dequeue();
				tw += c.getWaitingTime(r.getTime());
				System.out.println("Table for "+c.getName()+" (time = "+r.getTime()+" hours)");
			}
			else if (r.getLetter()=='Q') //Quit
			{
				System.out.println("");
				System.out.println("**Simulation Terminated**");
				break; //Breaks Out of Loop
			}
		}

		System.out.println("");
		System.out.println("The Average Waiting Time was "+tw/B+" hours.");
		System.out.println("The following parties were never seated:");
		while (!customers.isEmpty()) //Loop Finds Parties People Still Waiting
		{
			c = (restaurant)customers.dequeue();
			if (c.getNumber()==1)
				System.out.println("\tparty "+c.getName()+" of "+c.getNumber()+" person.");
			else
				System.out.println("\tparty "+c.getName()+" of "+c.getNumber()+" people.");
		}
		System.out.println("");
		System.out.println("Have a nice meal!");
	}
}