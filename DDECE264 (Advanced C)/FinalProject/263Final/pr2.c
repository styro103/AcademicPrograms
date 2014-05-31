#include "pr1.h"
#include "pr2.h"
#include <time.h>

int totalScore = 0;
int totalMisses = 0;;

struct word *addNewWordsToQ(struct word *tail,struct word *newWordsHead)
{
	struct word *walker; //Will Traverse Path

	if (newWordsHead==NULL) //If Empty Line
		return tail; //Return Tail as New Tail
	else
	{
		sortWordList(newWordsHead); //Sort Linked List
	
		tail->nextWord = newWordsHead; //Attach newWordsHead to Tail
	
		walker = newWordsHead; //Set walker Equal to newWordsHead
	
		while(walker->nextWord != NULL) //While Walker Isn't Equal to New Tail
			walker = walker->nextWord; //Make Walker Equal to nextWord

		return walker; //Return Walker as new Tail
	}
}

struct word *process_myQ (struct word * head)
{
	struct word * walker = head; //Will Traverse Path

	while(walker!= NULL) //While Walker is at A Word
	{
		walker->lineNo--; //Decrease lineNo of That Word
		
		if (walker->lineNo == 0) //If LineNo is Zero
		{
			totalMisses++; //Increment Total Misses
		
			if (totalMisses >= MAX_MISS_COUNT) //If TotalMisses Reaches Max
				appTerminate(head); //Call Function to End Game
			else
			{
				walker = head->nextWord; //Make Walker Equal to NextWord
				free(head); //Free Head
				head = walker; //Make NextWord New Head
			}
		}
		else
			walker = walker->nextWord; //Go to Next Word
	}
	
	return head;
}


/*The word list is sorted in the order of (lineNo, columnNo), so basically you just need to iterate the word list for head to tail */
void display_myQ (struct word *head)
{
	struct word * walker = head; //Will Traverse Path
	int line; //Holds Line Number
	int column; //Holds Column Number

	for (line=1; line<=MAX_LINE_NUMBER; line++)
	{
		printf("%3i", line); //Print Line Number
		
		for (column=0; column <5; column++)
		{
			if (walker!=NULL)
			{
				if (walker->lineNo == line && walker->columnNo == column)
				{
					printf("%10s", walker->text); //If Word There, Print Word
					walker = walker->nextWord;
				}
				else
					printf("          "); 
			}
			else
				printf("          "); //Else Print 10 Spaces
		}

		printf("\n"); //End Line
	}
	
}

struct word *matchWord(struct word *head,char *input)
{
	struct word * walker = head; //Will Traverse Path
	struct word * temp1 = head; //Temporary Pointer for Previous Word
	struct word * temp2 = NULL; //Temporary Pointer for Next Word
	int flag[MAX_COLUMNS] = {0,0,0,0,0}; //Check Columns
	int i;

	while (walker!=NULL)
	{
		if (strcmp(walker->text,input) == 0 && flag[walker->columnNo] !=1) //If Input is Equal to Word
		{
			printf("\a\a"); //Play Correct Sound
			totalScore+= walker->priority; //Increase Score by Priority
			temp2 = walker->nextWord; //Make Temp2 Equal to Next Word
			
			if (walker==head) //If Word is Head Position
			{
				walker = walker->nextWord;
				free(head);
				head = walker;
			}
			else
			{
				free(walker); //Free Walker, Thus Breaking the Link
				walker = temp2; //Move Walker to Next Word
				temp1->nextWord = walker; //Reconnect the Link
			}

			break;
		}
		else
		{
			flag[walker->columnNo] = 1;

			//Check if Any Column Hasn't Been Checked
			for (i=0; i<5; i++)
			{
				if (flag[i]==0)
					break;
			}

			//If All Columns Have Been Checked, Stop Scanning
			if (i==5)
			{
				break;
			}

			//Keep Temp Always Pointing to Word Before Walker
			if (walker!=head)
			{
				temp1=temp1->nextWord;
			}

			walker = walker->nextWord;
		}
	}

	return head; //Return New Head
}


struct word * delete_LinesOfWords(struct  word *head,  int lines)
{
	struct word * walker = head; //Will Traverse Path

	//Deletes Head of List and Makes Next Node New Head Until New Head is Above Line Number
	while (head->lineNo<=10)
	{
		walker=head->nextWord;
		free(head);
		head = walker;
	}

	return head; //Return New Head
}

void display_Statistics()
{
	printf("Total Score: %i\n", totalScore); //Print Total Score
	printf("Misses: %i\n", totalMisses); //Print Misses
}


void appTerminate (struct word *head)
{
	struct word * walker = head; //Will Traverse Path
	int line; //Holds Line Number
	int column; //Holds Column Number
	struct tm * timeinfo; //For Current Time
	FILE * write = NULL; //To Write to File
	time_t current; //For Current Time
	
	time (&current); 
	
	timeinfo = localtime (&current);

	write = fopen("remainingWord.txt", "w");
	
	for (line=0; line<=MAX_LINE_NUMBER; line++)
	{
		fprintf(write,"%3i", line); //Print Line Number
		
		for (column=0; column <5; column++)
		{
			if (walker!=NULL)
			{
				if (walker->lineNo == line && walker->columnNo == column)
				{
					fprintf(write,"%10s", walker->text); //If Word There, Print Word
					walker = walker->nextWord;
				}
				else
					fprintf(write,"          "); 
			}
			else
				fprintf(write,"          "); //Else Print 10 Spaces
		}

		fprintf(write,"\n"); //End Line
	}
	
	fprintf(write,"\n");
	fprintf(write,"\n");
	fprintf(write,"Total Score: %i\n", totalScore); //Print Score
	fprintf(write,"Total Misses: %i\n", totalMisses); //Print Misses
	fprintf(write,"Current Time: %i\n",asctime(timeinfo));

	fclose(write);
	free_list(head); //Free List
	exit (EXIT_SUCCESS);
}

void free_list(struct word *head)
{
	struct word *walker = head; //Will Traverse Path

	//traverse each node and free it
	while(walker!=NULL)
	{
		walker = head->nextWord;
		free(head);
		head = walker;
	}
}

void set_priority (struct word *head,  int newPriority)
{
	struct word *walker = head; //Will Traverse Path

	while (walker!=NULL)
	{
		walker->priority = newPriority; //Make Word Priority New Priority
		walker = walker->nextWord; //Make Walker Next Word
	}
	
}

struct word * sortWordList(struct word *head)
{	
	struct word *walker = head; //Will Traverse Path
	struct word *temp1 = NULL; //Previous Word
	struct word *temp2 = walker->nextWord; //Next Word
	int count = 1; //Count

	while (count < 4)
	{
		walker = head; //Initialize walker to Head
		temp1 = NULL; //And temp1 to Null
		temp2 = walker->nextWord; //And temp2 to Next Word 

		while (temp2) //temp2!=NULL
		{
			if (walker->columnNo > temp2->columnNo) //If columnNo of Walker is Greater Than Next Word's
			{
				if (walker==head) //Special Case Swap
				{
					walker->nextWord = temp2->nextWord;
					temp2->nextWord = walker;
					temp1 = temp2;
					head = temp1;
					temp2 = walker->nextWord;
				}
				else //Regular Case Swap
				{
					walker->nextWord = temp2->nextWord;
					temp2->nextWord = walker;
					temp1->nextWord = temp2;
					//update pointer positions
					temp1 = temp2;
					temp2 = walker->nextWord;
				}
			}
			else //No Swap
			{
				temp1 = walker;
				walker = temp2;
				temp2 = temp2->nextWord;
			}
		}

		count++; //Increment Count
	}
	
	return head; //Return new Head
}