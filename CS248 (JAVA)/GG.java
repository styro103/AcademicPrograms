/*
Shaun Mbateng
Project 1 - Guessing Game Program
CS 248
Janurary 18, 2011
*/

import java.io.*;
import java.util.*;

class GG
{
	static Scanner kbd;
	
	static void intro() //Required Function: Displayed Before User Input
	{
		System.out.println("");
		System.out.println("**Guessing Game**");
		System.out.println("A number between 1 and 100 is going to be picked and you'll have to find it.");
		System.out.println("");
	}
	
	public static void main(String [] args) throws IOException
	{
		intro(); //Calls Required Function
		String Y;
		Y = "yes";
		kbd = new Scanner(System.in);
		do{
			int user = 0;
			int number;
			int insult;
			number = (int)(1+100*Math.random());
				
			Scanner cin=new Scanner(System.in);
			System.out.println("I've got my number. Try to guess it.");
			System.out.println("");
			while (user!=number)
			{	
				user = cin.nextInt();
				System.out.println("");
				insult = (int)(1+5*Math.random());
				if (user<1 || user>100)
				{
					System.out.println("That number isn't even in the range. How stupid are you? Try again. ");
					System.out.println("");
				}
				else if (user>number)
				{
					System.out.println("Too High.");
					if (insult==1)
					{
						System.out.println("You got it wrong...idiot!");
					}
					if (insult==2)
					{
						System.out.println("Looks we'll be playing for awhile.");
					}
					if (insult==3)
					{
						System.out.println("Haha! You stink!");
					}
					if (insult==4)
					{
						System.out.println("Well you're a fool haha!");
					}
					if (insult==5)
					{
						System.out.println("Maybe you should give up. Just a suggestion.");
					}
				}
				else if (user<number)
				{
					System.out.println("Too Low.");
					if (insult==1)
					{
						System.out.println("You got it wrong...idiot!");
					}
					if (insult==2)
					{
						System.out.println("Looks we'll be playing for awhile.");
					}
					if (insult==3)
					{
						System.out.println("Haha! You stink!");
					}
					if (insult==4)
					{
						System.out.println("Well you're a fool haha!");
					}
					if (insult==5)
					{
						System.out.println("Maybe you should give up. Just a suggestion.");
					}
				}
				else if (user==number)
				{
					System.out.println("You got the number. Nice!");
				}

				System.out.println("");
			}
			System.out.println("Would you like to play again? (yes/no)");
			System.out.println("");
			Y = kbd.nextLine();
			System.out.println("");
			/*while (Y!="yes" && Y!="no")
			{
				System.out.println("That's not one of the options idiot. Type yes or no.");
				Y = kbd.nextLine();
			}*/
			if (Y.equalsIgnoreCase("yes"))
			{
				System.out.println("Alright!!!");
			}
			if (Y.equalsIgnoreCase("no"))
			{
				System.out.println("Boo! You stink!!!");
			}
			System.out.println("");
		}while (Y.equalsIgnoreCase("yes"));
	}
}