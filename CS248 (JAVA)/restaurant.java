//Chris Johnson

import java.io.*;
import java.util.*;

public class restaurant
{
	// creating data markers
	int time, number;
	String name;
	char letter;

	// initializing the data markers
	public restaurant()
	{
		time=number=0;
		name="";

	}

	//constructor
	public restaurant(char l,String n, int t, int n1)
	{
		letter=l;
		name=n;
		time=t;
		number=n1;

	}

	public int getWaitingTime(int seatTime)
	{
		return seatTime - time;
	}

	public restaurant(Scanner cin)
	{
		String line = cin.nextLine();
		String[] split = line.split(" ");

		letter=split[0].charAt(0);

		if (letter == 'A')
		{
			time=Integer.parseInt(split[1]);
			number=Integer.parseInt(split[2]);

			line = split[3];
			for (int a = 4; a < split.length; a++)
				line += " " + split[a];
			name=line;
		}
		else if (letter == 'T')
			time=Integer.parseInt(split[1]);
	}

	public String toString()
	{
		return letter + " " + time + " " + number + " "  + name;
	}

	public int getTime()	{return time;}
	public int getNumber()	{return number;}
	public String getName() {return name;}
	public char getLetter() {return letter;}

}

