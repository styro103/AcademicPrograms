//*********************************************************
// Shaun Mbateng
// Homework 2
// Date: April 30, 2014
// This program merges presorted arrays into one big sorted array
//***********************************************************

#include <iostream>
#include <stdlib.h>
#include <limits.h>
using namespace std;

void copy(int * tmp, int * a, int a_size);
void print(int arr [], int n);
void merge(int s [], int a [], int b [], int c [], int n, int size);

int main()
{
	//Presorted Mini Arrays
	int a [5] = {1, 4, 7, 10, 13}; 
	int b [5] = {2, 5, 8, 11, 14}; 
	int c [5] = {3, 6, 9, 12, 15};
	
	//Final Array to be Sorted
	int s [15];
	
	//Print Welcome Message
	cout<<""<<endl;
	cout<<"***Array Merger Program***"<<endl;
	cout<<""<<endl;
	//Print Presorted Mini Arrays
	cout<<"Presorted Mini Arrays"<<endl;
	print(a, 5);
	print(b, 5);
	print(c, 5);
	cout<<""<<endl;
	
	//Merging Function Called Here	
	merge(s, a, b, c, 5, 15);
	
	//Print Giant Sorted Array
	cout<<"Final Sorted Array"<<endl;
	print(s, 15);
	cout<<""<<endl;
	
	return 0;
}

void print(int arr [], int n) //Traverses Through and Prints Each Element
{
	for (int i = 0; i<n; i++)
		cout<<arr[i]<<" ";
	
	cout<<""<<endl;
}

void merge(int s [], int a [], int b [], int c [], int n, int size) //Merge Function
{
	int start = 0, stop = n-1; //Integers to Hold Position in Array
	int x = start, y = start, z = start; //Integers to Traverse Mini Arrays
	int min; //Integer to Hold Minimum Value
	
	for (int i=0; i<size; i++) //Fills Final Array
	{
		//If x, y, or z is Greater than stop (All Elements of Respective Mini Array Been Placed in Final Array)
		//	Make x = Last Element Index, Make Element in Mini Array Max Possible Integer
		//	Assures That Won't be Used Again
		if (x>stop)
		{
			x = n-1;
			a[x] = INT_MAX;
		}
		if (y>stop)
		{
			y = n-1;
			b[y] = INT_MAX;
		}
		if (z>stop)
		{
			z = n-1;
			c[z] = INT_MAX;
		}
		
		//Make min the Minimum Value of All Three Elements Being Compared
		min = b[y]^((a[x]^b[y]) & -(a[x]<b[y]));
		min = c[z]^((min^c[z]) & -(min<c[z]));
		
		//Depending on Which Element was the minimum, Increment Respective Index
		if (min == a[x])
			x++;
		else if (min == b[y])
			y++;
		else if (min == c[z])
			z++;
		
		s[i] = min; //Place min in Final Array
	}
}