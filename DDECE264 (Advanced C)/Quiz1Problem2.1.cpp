#include <stdio.h>
#include <iostream.h>

//Part 2 Problem 1

int main()
{
	short WR[22]; 
	short * p; 
	double TR[10]; 
	double * q;
	
	/*  we now make the following assignments*/	
	p = WR+2; 
	q = TR+6;
	
	cout<<"p: "<<p<<endl;
	cout<<"q: "<<q<<endl;
	cout<<"--p: "<<--p<<endl;

	return 0;
}
