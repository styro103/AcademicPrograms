/*ECE 264
  Lab 01
  Problem 02
  Shaun Mbateng
  This program takes inputs into an integer array a negative number is entered, displays it,
		reverses it, and displays it again
*/

#include <stdio.h>
#include <iostream>
using namespace std;

void printArray(int arr[], int size);
void reverseArray(int & arr[], int size);

int main()
{
	int Values[25];
	int i = 0;

	while (i<25) //Until Full Size of "Values"
	{
		cout<<"Enter element number "<<(i+1)<<":"<<endl; 
		cin>>Values[i]; //Enter Element
		if (Values[i] < 0) //If Element is Negative
			break; //Break out of Loop
		i++; //Increment i
	}

	printArray(Values, i); //Print Array
	reverseArray(Values, i); //Reverse Array
	printArray(Values, i); //Print Array Again

	return 0;
}

void printArray(int arr[], int size) //Print Array in A Single Line
{	
	for (int j = 0; j <= size; j++)
		cout<<arr[j]; //Print Array in A Single Line
	cout<<""<<endl; //New Line

}

void reverseArray(int & arr[], int size) //Reverse Array
{
	int temp; //Temporary Variable
	int Mid; //Mid Point

	if (size % 2 == 0) //If Size is Even
		Mid = size/2; //Mid is Exact Half Way Point
	if (size % 2 != 0) //If Size is Odd
		Mid = size/2 + 1; //Stop at Next Highest Integer of EXACT Half Way Value

	for (int j = size; j >= Mid; j--) //This For Loop Reverses the Array
	{
		temp = arr[j]; //Make Temp Element at Position j
		arr[j] = arr[size-j]; //Make Element at Position j the Element at Position size - j
		arr[size-j] = temp; //Make Element at Position size - j temp
	}
}
