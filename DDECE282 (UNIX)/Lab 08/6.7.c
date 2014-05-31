/*
Problem 6.7 SigDemo1
Shaun Mbateng
ECE 282
Editing Sig Demo 1 to Count for Ctrl-C Presses
*/

#include <stdio.h>
#include <signal.h>

static int count = 0;

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
	
	int i;
	
	count++;
	printf("\n");
	printf("OUCH");
	
	for (i=1; i<=count; i++)
		printf("!");
	
	printf("\n");
}
