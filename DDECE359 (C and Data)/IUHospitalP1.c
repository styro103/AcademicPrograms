/*
 *	Shaun Mbateng
 *	ECE 359 - C and Data Structures
 *	J. Ling
 *	HMWK #1 - Problem 1
*/

#include<stdio.h>
#include <string.h>

static char appointments[100]; //Array of Appointments

void size(); //Function to Return Number of Patients
void newAppointment(); //Function to Create New Appointment/Add to Queue
void appointmentDone(); //Function to Finish Appointment/Delete From Queue

int main()
{
	int command; //Command Input
	
	command = 0; //Set Command to 0

	printf("***Welcome to the IU Hospital Database Program!***\n"); //Welcome Message

	do //Continuous Until User Selects Quit Option
	{
		//Introduction
		printf("\n");
		printf("Select from One of the Options Below:\n");
		printf("1.   Show Number of Current Patients\n");
		printf("2.   Schedule New Appointment\n");
		printf("3.   End Earliest Scheduled Appointment\n");
		printf("4.   Quit Program\n");
		printf("\n");

		scanf("%i", &command); //Input Command
		getchar(); //Get NewLineCharacter After (For gets() Further Down)
		printf("\n");

		//Depending on Input, Call Respective Function, Or Print Message
		if (command == 1)
			size();
		else if (command == 2)
			newAppointment();
		else if (command == 3)
			appointmentDone();
		else if (command == 4)
			printf("Goodbye User!\n\n");
		else
			printf("That is Not an Option, Select Again.\n");
	} while (command != 4);

	return 1;
}

void size()
{
	int size;
	int i;
	int endcom;

	size = 0;
	endcom = 0;
	
	for (i = 0; i < strlen(appointments); i++)
	{
		if (appointments[i] == ',')
			size++;
	}

	//Print Message Depending on Amount
	if (size == 1)
		printf("There is %i patient currently in the system.\n", size);
	else
		printf("There are %i patients currently in the system.\n", size);
}

void newAppointment() //Add Entry to Queue
{
	char name[20];
	printf("What is the patient's name?\n");
	gets(name);
	strcat(appointments, name); //Add Patient to End of List)
	strcat(appointments, ", "); //Add Seperator After Name
}

void appointmentDone() //Delete Entry From Queue
{
	if (strlen(appointments) != 0) //If Appointments Exist
	{
		char name[20]; //Will Hold Patient Name
		int pos; //Will Hold A Position
		
		for (pos = 0; pos < strlen(appointments); pos++) //Run Though Appointments Array
		{
			if (appointments[pos] == ',') //Get Position of First Comma
				break;
		}

		strncpy(name, appointments, pos); //Makes Name Equal to Name of Removed Entry
		strcpy(appointments, appointments + pos+2); //Remove First Patient Entry from Array
		name[pos] = '\0'; //Manually Add Null to End of Name
		printf("%s was removed from the system.\n", name); //Display Completion
	}
	else
		printf("There are no appointments.\n"); //Display
}