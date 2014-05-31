/*
Problem 6.7 SigDemo1
Shaun Mbateng
ECE 282
Editing Sig Demo 1 to Ask User to Quit
*/

#include <stdio.h>
#include <signal.h>

main()
{
	void f(int);
	int i;
	
	signal(SIGINT,f);
	
	for (i=0; i<5; i++)
	{
		printf("Hello\n");
		sleep(1);
	}
}

void f(int signum)
{
	signal(SIGINT,f);
	
	char quit = 'n';
	
	printf("\n");
	printf("\n");
	printf("Did you mean to quit? (y/n)\n");
	scanf("%c", &quit);
	
	while (quit!='y' && quit!='n')
	{
		printf("\n");
		printf("That is not one of the options.\n");
		printf("Enter y or n.\n");
		scanf("%c", &quit);
	}
	
	if (quit == 'y')
	{
		printf("\n");
		printf("Bye Bye!\n");
		exit("6.8.c");
	}
}
