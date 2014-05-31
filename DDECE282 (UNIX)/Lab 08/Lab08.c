/*
Lab 08
Shaun Mbateng
ECE 282

This Lab Prints Random Numbers, and if Ctrl-C or Ctrl-Z
	is Pressed, it Does A Certain Action
*/

#include <stdio.h>
#include <stdlib.h>
#include <signal.h>

void CTRLC(int signum); //Interrupt Signal Funtion
void CTRLZ(int signum); //Quit Signal Function
void QUIT(int signum);
void INSERT(int number); //Insert Number Functino

static int tennumbers[10]; //Array of Ten Numbers
static int size = 0; //Integer of Size

int main()
{
	int T; //Sleep Time
	int count = 0; //Numbers Count
	int position = 0; //Element Number in Array
	int number; //Number to be Printed
	char run = 'Y'; //To Keep the Program Running
	
	srand(time(NULL));
	
	signal(SIGTSTP, CTRLZ);
	
	printf("\n");
	printf("What is the sleep time in seconds?\n");
	scanf("%i", &T); //Get Sleep Time
	printf("\n");
	printf("Printing random number every %i second(s):\n", T);
	
	signal(SIGINT, CTRLC); //Can't be Activated Until After Sleep Time Has Been Entered
	
	while (run == 'Y') //Will Constantly Run
	{
		number = rand() % 100 + 1; //Generate Random Number from 1 to 100
		printf("%i\n", number); //Print Number
		count++; //Increment Count
		
		if (count>10) //If There Has Been More Than 10 Numbers 
		{	
			INSERT(number); //Insert New Number
		}
		else //Put Number Into Integer Array
		{
			tennumbers[position] = number; //Place Number in Array
			position++; //Increment Position
			size++;
		}
		
		sleep(T);
	}
	
	return 0;
}

void INSERT(int number) //Inserts New Number Into Array, and Moves Other Numbers One Spot to the Left
{
	int i;

	for (i=0; i<(size-1); i++) //From 1st to Penultimate Element
	{
		tennumbers[i] = tennumbers[i+1]; //Make Element Value of Element to Immediate Right
	}
	
	tennumbers[size-1] = number; //Make Last Element Value of number
}

void CTRLC(int signum) //Prints Average of Numbers of Array
{
	signal(SIGINT, CTRLC);
	
	if (size <= 0)
	{
		printf("No numbers have been entered yet.\n"); //If No Numbers Have Been Entered, Display This
	}
	
	else
	{	
		int sum = 0; //Set Sum to Zero
		int ave = 0; //Set Average to 0
		int i;
		
		for (i=0; i<size; i++) //Will Run From 0 to Array Size-1
		{
			sum+=tennumbers[i]; //Adds Numbers
		}
		
		ave = sum/size; //Finds Average
		printf("\n");
		printf("The Average of the Last %i Numbers is: %i\n", size, ave); //Display Size and Average
	}
	
	
}

void CTRLZ(int signum)
{
	signal(SIGTSTP, CTRLZ);
	
	printf("\n");
	printf("Bye Bye!\n");
	exit("Lab08.c");
}
