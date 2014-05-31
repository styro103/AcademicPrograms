#include "prj.h"
#include "pr1.h"
#include "pr2.h"
#include <windows.h> 

#define RANDOM_TYPE 1
struct word *head = NULL;
struct word *tail = NULL;

CRITICAL_SECTION critSection;

void scanInput();
void refreshScreen();

int main()
{
	struct word *myQ=NULL;
	struct word* tmp,*prev;
	int halfSecs = 0;
	DWORD dwThreadId;	

	InitializeCriticalSection(&critSection);

	/*Create several words first*/
	while(myQ == NULL)
		myQ = genNewWords(RANDOM_TYPE);
	myQ = sortWordList(myQ);
	head = myQ;
	tmp = head;
	while(tmp != NULL)
	{
		prev = tmp;
		tmp = tmp->nextWord;
	}
	tail = prev;

	printf( "\033[2J"); //clear screen

	/*Create scanInput thread*/
	if (CreateThread(NULL, //Choose default security
		0, //Default stack size
		(LPTHREAD_START_ROUTINE)&scanInput,//Routine to execute
		(LPVOID) NULL, //Thread parameter
		0, //Immediately run the thread
		&dwThreadId //Thread Id
		) == NULL)
	{
		printf("Error Creating Thread\n");
		return(1);
	}


	while(1)
	{
		Sleep(500);//0.5 seconds
		halfSecs++;
			
		if(halfSecs == 3)//3*0.5 = 1.5 seconds
		{
			EnterCriticalSection(&critSection);
			head = process_myQ(head);			
			myQ = genNewWords(RANDOM_TYPE);
			tail = addNewWordsToQ(tail,myQ);			
			halfSecs = 0;
			refreshScreen();
			LeaveCriticalSection(&critSection);
		}		
	}
	return 1;
}

void refreshScreen()
{
	printf( "\033[s");//save cursor position
	printf( "\033[3;1H");//go to line 3		
	printf("====================================================\r\n");
	display_myQ(head);
	printf("====================================================\r\n");
	display_Statistics();
	printf( "\033[u");//restore cursor position
}

void scanInput()
{
	int pos = 0;
	char input[10];
	while(1)
	{		
		EnterCriticalSection(&critSection);
		printf( "\033[2;1H");//go to line 2
		printf( "\033[K");//clear whole line first
		printf( "\033[2;1H");//go to line 2 again
		printf("Input your word:");
		LeaveCriticalSection(&critSection);
		scanf("%s",input);

		EnterCriticalSection(&critSection);
		if(strcmp(input,"help") == 0)
			head = delete_LinesOfWords(head,10);
		else if(strcmp(input,"bigDaddy") == 0)
			set_priority(head,100);
		else
			head = matchWord(head,input);
		refreshScreen();	
		LeaveCriticalSection(&critSection);

	}
}





