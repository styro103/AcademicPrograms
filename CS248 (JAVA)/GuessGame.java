/*
Guessing Game Program
Made by Shaun Mbateng
This Program Picks A Random Integer Between 1 and 100, and the User
	has to Guess it
*/

import java.io.*;
import java.util.*;

class GuessGame
{
	static void intro()
	{
		System.out.println("");
		System.out.println("**Guessing Game**");
		System.out.println("A number between 1 and 100 is going to be picked and you'll have to find it.");
		System.out.println("");
	}
	
	public static void main(String [] args)
	{
		intro();
		int Y = 1;
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
			System.out.println("Would you like to play again? Type 1 for yes or 0 for no.");
			System.out.println("");
			Y = cin.nextInt();
			System.out.println("");
			while (Y!=1 && Y!=0)
			{
				System.out.println("That's not one of the options idiot. Type 1 or 0.");
				Y = cin.nextInt();
			}
			if (Y==1)
			{
				System.out.println("Alright!!!");
			}
			if (Y==0)
			{
				System.out.println("Boo! You stink!!!");
			}
			System.out.println("");
		}while (Y==1);
	}
}