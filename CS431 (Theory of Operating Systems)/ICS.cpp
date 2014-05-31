//***********************************************************************************
// Project 1 - Interactive Command Shell
// Author: Shaun Mbateng
// Class: Theory of Operating Systems
//***********************************************************************************

#include <sys/types.h>
#include <sys/wait.h>
#include <iostream>
#include <sstream>
#include <string.h>
#include <stdlib.h>
#include <unistd.h>
#include <stdio.h>

using namespace std;  

int fk();

int main()
{
	char command[1024];
	bool running = true;
	char prompt[100] = "ICS> ";
	
	do
	{
		cout<<prompt;
		gets(command);
		cout<<command;
		
	} while (!strcmp("exit", command));
}

int fk()
{
	int status = 0;
		pid_t pid;

		//fork a child process
		pid = fork();

		if(pid < 0) // error scenario 
		{ 
			cerr << "fork() failed\n" << endl;
			exit(-1);
		}
		else if (pid == 0) // child process 
		{ 
			execlp("/bin/ps", "ps", NULL);
		}
		else // parent process 
		{ 
			// parent will wait for child to complete 
			wait(&status);
			cout << "\nChild complete\n" << endl;
			exit(0);
		}
}
