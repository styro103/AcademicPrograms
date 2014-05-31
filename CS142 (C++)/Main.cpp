// Main.cpp 

#include <iostream.h>
#include <fstream.h> 

int MultTwo(int,int); 
int MultFour(int,int,int,int); 
void PrintHead(); 

int a,b,c,d,e; 

int main() 
{ 
	PrintHead(); 
	return 0; 
} 

void PrintHead() 
{ 
	cout<<""<<endl;
	cout<<"Welcome to Multiply Program!"<<endl; 
	cout<<"Written by: Rich C."<<endl; 
	cout<<""<<endl;
	a=1; 
	b=2; 
	c=MultTwo(a,b); 
	d=5; 
	e=MultFour(a,b,c,d); 
	cout<<e<<endl; 
} 

int MultTwo(int x, int y) 
{ 
	return (x*y); 
} 

int MultFour(int m, int n, int o, int p) 
{ 
	return (m*n*o*p); 
}
