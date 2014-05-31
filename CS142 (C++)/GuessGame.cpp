//***********************************************************************************
// Project 4--The Guessing Game
// Author: [Shaun Mbateng]
//Session: Chen - 11:00 A.M. - Monday, Wednesday, Friday
//Date: February 26, 2010 
//This program picks a random number, and the user has to guess it.
//The Game doesn't stop till the user guesses the number, and
//depending on how off the user's guess is, a different message is displayed. 
//After the right number is guessed, it asks the user if he/she wants to play again. 
//***********************************************************************************

#include <iostream.h>
#include <stdlib.h>
#include <time.h>

void welcome();

int main()
{
	int number;
	int user;
	char Y='y';
	
	welcome();
	
	do{
		//Create Random Number
		srand(time(NULL));
		number=1+rand()%100;
		cout<<"Pick a number between 1 and 100. ";
		
		//Loop Until Number is Found
		while (user!=number)
		{
			cin>>user;
			cout<<""<<endl;
			if (user<1 || user>100)
			{
				cout<<"That isn't even in the range. How stupid are you? Try again. "<<endl;
				cout<<""<<endl;
			}
			else if (user>number)
			{
				int d;
				d=user-number;
				if (d>=50)
				{
					cout<<"You actually though the number would be THAT high? Idiot!!! Try again. "<<endl;
					cout<<""<<endl;
				}
				else if (d>10 && d<50)
				{
					cout<<"You're too high dimwit! Try again. "<<endl;
					cout<<""<<endl;
				}
				else if (d>5 && d<10)
				{
					cout<<"You're over by a bit. Try again. "<<endl;
					cout<<""<<endl;
				}
				else if (d<=5)
				{
					cout<<"You close, just a small amount over. Try again. "<<endl;
					cout<<""<<endl;
				}
			}
			else if (number>user)
			{
				int d;
				d=number-user;
				if (d>=50)
				{
					cout<<"Wow, your number is way too low you dunce! Try again. ";
					cout<<""<<endl;
				}
				else if (d>10 && d<50)
				{
					cout<<"You're too low moron! Try again. "<<endl;
					cout<<""<<endl;
				}
				else if (d>5 && d<10)
				{
					cout<<"You're under by a bit. Try again. "<<endl;
					cout<<""<<endl;
				}
				else if (d<=5)
				{
					cout<<"You close, just a small amount under. Try again. "<<endl;
					cout<<""<<endl;
				}
			}
			else
			{
				cout<<""<<endl;
				cout<<"You got the number! Nice!"<<endl;
			}
		}
		
		cout<<""<<endl;
		cout<<"Would you like to play again? (y/n) ";
		cin>>Y;
		cout<<""<<endl;
		if (Y=='n')
		{	
			cout<<"Boo! You stink!"<<endl;
		}
		else if (Y=='y')
		{
			cout<<"Alright!!!"<<endl;
		}
		
		cout<<""<<endl;
	}while (Y=='y');
	
	return 0;
}

void welcome()
{
	cout<<""<<endl;
	cout<<"**Welcome to the guessing game!**"<<endl;
	cout<<"A number is going to be randomized and you'll have to find it."<<endl;
}
