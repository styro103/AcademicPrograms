/*
Shaun Mbateng
Candy Vending Machine Program
This Program Works Like a Vending Machine and Switches Betweens States
*/

import java.io.*;
import java.util.*;

class CandyVend
{
	static int Coin; //Coin Input/Candy Selection
	static int Total; //Keeps Track of Total Change
	static Scanner cin; //For Entering Integers

	public static void main(String [] args) throws IOException
	{

		cin = new Scanner(System.in);

		Coin = 0; //Start Coin at 0
		Total = 0; //Start Total at 0

		System.out.println("");
		System.out.println("***Hello Hungry Customer***"); //Intitial Message

		while (Coin<1 || Coin>3) //Stays in State Until Appropriate Option is Selected
		{
			System.out.println("You Have "+Total+"¢, What Would You Like to Insert?"); //States Change Amount
			System.out.println("1. Nickel (5¢)");
			System.out.println("2. Dime (10¢)");
			System.out.println("3. Quarter (25¢)");
			System.out.println("");
			Coin = cin.nextInt();
			System.out.println("");

			//The following if/else if/else Statements Determine Which Function (State) to go to Next Depending on Coin Input
			if (Coin == 1)
			{
				Total = Total+5;
				State_Five();
			}

			else if (Coin == 2)
			{
				Total = Total+10;
				State_Ten();
			}

			else if (Coin == 3)
			{
				Total = Total+25;
				State_Twenty_Five();
			}

			else
			{
				System.out.println("That is Not One of the Options."); //Shown If Random Number is Selected but Not an Option
			}
		}
	}

	//The Next Five State Functions Work Very Similarily. The Only Difference is the State Jumped to
	static void State_Five() throws IOException
	{
		Coin = 0; //Reset Coin to Zero

		while (Coin<1 || Coin>3)//Stays in State Until Appropriate Option is Selected
		{
			System.out.println("You Have "+Total+"¢, What Would You Like to Insert?");
			System.out.println("1. Nickel (5¢)");
			System.out.println("2. Dime (10¢)");
			System.out.println("3. Quarter (25¢)");
			System.out.println("");
			Coin = cin.nextInt();
			System.out.println("");

			if (Coin == 1)
			{
				Total = Total+5;
				State_Ten();
			}

			else if (Coin == 2)
			{
				Total = Total+10;
				State_Fifteen();
			}

			else if (Coin == 3)
			{
				Total = Total+25;
				State_Thirty_or_More();
			}

			else
			{
				System.out.println("That is Not One of the Options.");
			}
		}
	}

	static void State_Ten() throws IOException
	{
		Coin = 0;

		while (Coin<1 || Coin>3)//Stays in State Until Appropriate Option is Selected
		{
			System.out.println("You Have "+Total+"¢, What Would You Like to Insert?");
			System.out.println("1. Nickel (5¢)");
			System.out.println("2. Dime (10¢)");
			System.out.println("3. Quarter (25¢)");
			System.out.println("");
			Coin = cin.nextInt();
			System.out.println("");

			if (Coin == 1)
			{
				Total = Total+5;
				State_Fifteen();
			}

			else if (Coin == 2)
			{
				Total = Total+10;
				State_Twenty();
			}

			else if (Coin == 3)
			{
				Total = Total+25;
				State_Thirty_or_More();
			}

			else
			{
				System.out.println("That is Not One of the Options.");
			}
		}
	}

	static void State_Fifteen() throws IOException
	{
		Coin = 0;

		while (Coin<1 || Coin>3)//Stays in State Until Appropriate Option is Selected
		{
			System.out.println("You Have "+Total+"¢, What Would You Like to Insert?");
			System.out.println("1. Nickel (5¢)");
			System.out.println("2. Dime (10¢)");
			System.out.println("3. Quarter (25¢)");
			System.out.println("");
			Coin = cin.nextInt();
			System.out.println("");

			if (Coin == 1)
			{
				Total = Total+5;
				State_Twenty();
			}

			else if (Coin == 2)
			{
				Total = Total+10;
				State_Twenty_Five();
			}

			else if (Coin == 3)
			{
				Total = Total+25;
				State_Thirty_or_More();
			}

			else
			{
				System.out.println("That is Not One of the Options.");
			}
		}
	}

	static void State_Twenty() throws IOException
	{
		Coin = 0;

		while (Coin<1 || Coin>3)//Stays in State Until Appropriate Option is Selected
		{
			System.out.println("You Have "+Total+"¢, What Would You Like to Insert?");
			System.out.println("1. Nickel (5¢)");
			System.out.println("2. Dime (10¢)");
			System.out.println("3. Quarter (25¢)");
			System.out.println("");
			Coin = cin.nextInt();
			System.out.println("");

			if (Coin == 1)
			{
				Total = Total+5;
				State_Twenty_Five();
			}

			else if (Coin == 2 || Coin == 3)
			{
				if (Coin == 2)
				{
					Total = Total+10;
				}

				else if (Coin == 3)
				{
					Total = Total+25;
				}

				State_Thirty_or_More();
			}

			else
			{
				System.out.println("That is Not One of the Options.");
			}
		}
	}

	static void State_Twenty_Five() throws IOException
	{
		Coin = 0;

		while (Coin<1 || Coin>3)//Stays in State Until Appropriate Option is Selected
		{
			System.out.println("You Have "+Total+"¢, What Would You Like to Insert?");
			System.out.println("1. Nickel (5¢)");
			System.out.println("2. Dime (10¢)");
			System.out.println("3. Quarter (25¢)");
			System.out.println("");
			Coin = cin.nextInt();
			System.out.println("");

			if (Coin == 1)
			{
				Total = Total+5;
			}

			else if (Coin == 2)
			{
				Total = Total+10;
			}

			else if (Coin == 3)
			{
				Total = Total+25;
			}

			else
			{
				System.out.println("That is Not One of the Options.");
			}
		}

		State_Thirty_or_More();
	}

	static void State_Thirty_or_More() throws IOException
	{
		Coin = 0;

		//A Littler Difference in This State
		while (Coin != 4)//Until Candy is Dispensed, Stays in This State
		{
			System.out.println("You Have "+Total+"¢, What Would You Like to Insert?");
			System.out.println("1. Nickel (5¢)");
			System.out.println("2. Dime (10¢)");
			System.out.println("3. Quarter (25¢)");
			System.out.println("4. Dispense Candy");
			System.out.println("");
			Coin = cin.nextInt();
			System.out.println("");

			//Now, The Coins get Added, but No State Jump.
			if (Coin == 1)
			{
				System.out.println("You Should Stop Entering Coins, This Doesn't Give Change."); //Warning Message to User
				Total = Total+5;
			}

			else if (Coin == 2)
			{
				System.out.println("You Should Stop Entering Coins, This Doesn't Give Change.");
				Total = Total+10;
			}

			else if (Coin == 3)
			{
				System.out.println("You Should Stop Entering Coins, This Doesn't Give Change.");
				Total = Total+25;
			}

			else if (Coin == 4) //Candy is Dispensed, Then Initial State is Returned to
			{
				System.out.println("Enjoy Your Candy!");
				System.out.println("");
				Total = 0; //Total Change Amount Reset to Zero
			}

			else
			{
				System.out.println("That is Not One of the Options.");
			}
		}
	}
}