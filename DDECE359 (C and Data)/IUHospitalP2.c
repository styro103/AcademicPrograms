/*
 *	Shaun Mbateng
 *	ECE 359 - C and Data Structures
 *	J. Ling
 *	HMWK #1 - Problem 2
*/

#include<stdio.h>
#include<stdlib.h>

void size(); //Function to Return Number of Patients
void newAppointment(); //Function to Create New Appointment/Add to Queue
void appointmentDone(); //Function to Finish Appointment/Delete From Queue

struct appointment
{
	char name[20]; //Patient Name
	struct appointment * next; 
};

int main()
{
	struct appointment * head;
	int command; //Command Input
	
	//Initialize
	head = NULL;
	command = 0;

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
		getchar(); //Get New Line Character After (For gets() Further Down)
		printf("\n");

		//Depending on Input, Call Respective Function, Or Print Message
		if (command == 1)
			size(&head);
		else if (command == 2)
			newAppointment(&head);
		else if (command == 3)
			appointmentDone(&head);
		else if (command == 4)
			printf("Goodbye User!\n\n");
		else
			printf("That is Not an Option, Select Again.\n");
	} while (command != 4);

	return 1;
}

void size(struct appointment * head)
{
	struct appointment * walker; //Traverse List
	int size; //To Hold Size
		
	//Initialize
	size = -1; //Adjust
	walker = head;

	while (walker != NULL)
	{
		size++;
		walker = walker->next;
	}

	//Depending on Size, Output Certain Message
	if (size == 1)
		printf("There is %i patient currently in the system.\n", size);
	else
		printf("There are %i patients currently in the system.\n", size);

}

void newAppointment(struct appointment * head)
{
	if (head == NULL)
	{
		head = (struct appointment *)malloc(sizeof(struct appointment)); //Create New Appointment
		printf("What is the patient's name?\n");
		gets(head->name); //Get Patient Name
		head->next = NULL;
	}
	else
	{
		struct appointment * walker; //Traverse List
		struct appointment * newnode; //New Appointment
		
		newnode = (struct appointment *)malloc(sizeof(struct appointment)); //Create New Appointment
		printf("What is the patient's name?\n");
		gets(newnode->name); //Get Patient Name
		
		//Move to the End of List
		walker = head;
		
		while(walker->next != NULL)
		{
			walker = walker->next;
		}
		
		//Add Appointment
		walker->next = newnode;
		newnode->next = NULL;
	}
}

void appointmentDone(struct appointment * head)
{
	if (head == NULL)
		printf("There are no patients.");
	else (head->next != NULL)
	{
		struct appointment * walker; //Traverse List
	
		free(head);
		walker = head->next;
		head = walker;
		printf("%s was Removed From the System", head->name);
	}
	else
	{
		free(head)
	}
}