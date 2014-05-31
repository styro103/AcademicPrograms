/*
SigDemo1
Shaun Mbateng
ECE 282
Demo of How Signal Works
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
	
	printf("OUCH!\n");
}
