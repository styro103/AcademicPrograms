/*ECE 264
  Lab 01
  Problem 03
  Shaun Mbateng
  This program takes an array, prints it, sorts it, and searches for an element all using multiple methods.
*/

#include <stdio.h>
#include <iostream>
using namespace std;

void printArray(double arr[], int size);
int linearSearch(double arr[], int size, double valueToSearchFor);
void copyArray(double  destination[], double source[], int size);
void bubbleSort(double  arr[], int size);
int binarySearch(double arr[], int size, double valueToSearchFor);

int main()
{
	double first[100]; 
	double second[100]; 
	double value; //Value to Search For
	int index; //Index of Value
	int i;

	for (i = 0; i < 100; i++) //fill First Array
	{
		cout<<"Enter element number "<<(i+1)<<":"<<endl;
		cin>>first[i];
		if (first[i]>999)
			break;
	}

	printArray(first, i); //Print first it

	cout<<"Enter 1st value to search for:"<<endl; //Enter Value to search for
	cin>>value;

	index = linearSearch(first, i, value); //call linear search function

	if (index == -1) //Display whether it is or isn't in the array
		cout<<"The value is not in the array."<<endl;
	else
		cout<<"The value is element number "<<index+1<<" in the array."<<endl;

	copyArray(second, first, i); //Copy array
	bubbleSort(second, i); //sort array
	printArray(second, i); //Print second array

	cout<<"Enter 2nd value to search for:"<<endl; //Enter Value to search for
	cin>>value;

	index = binarySearch(second, i, value); //Call binary search function

	if (index == -1)//Display whether it is or isn't in the array
		cout<<"The value is not in the array."<<endl;
	else
		cout<<"The value is element number "<<index+1<<" in the array."<<endl;

	return 0;
}

void printArray(double arr[], int size) // print array
{
	for (int j = 0; j <= size; j++) //prints array three elements at a time
	{	
		cout<<arr[j];
		if ((j+1) % 3 == 0) //if j+1 is a multiple of three
			cout<<""<<endl; //end line
	}
}

int linearSearch(double arr[], int size, double valueToSearchFor)
{
	bool Found = false;
	int j = 0;
	
	while (j <= size && arr[j] != valueToSearchFor) //Until array has been fully searched or value is found
	{
		if (arr[j] == valueToSearchFor) //if found
		{
			Found = true; 
		}

		j++
	}

	if (Found = false)
	{
		j = -1;
	}
	
	return j; //j either has value index, or negative one if not found
}

void copyArray(double  destination[], double source[], int size)
{
	for (int j = 0; j <= size; j++) //Copy array element by element
		destination[j] = source[j];
}

void bubbleSort(double  arr[], int size)
{
	int t = 0;
	int temp;

	while (t <= size) //Number of cycles is equal to size
	{
		for (int j = 1; j <= size; j++) //
		{
			if (arr[j-1] > arr[j]) //If element is smaller than element to immediate left, swap
			{
				temp = arr[j];
				arr[j] = arr[j-1];
				arr[j-1] = temp;
			}
		}

		t++;
	}
}

int binarySearch(double arr[], int size, double valueToSearchFor)
{
	int top = 0;
	int bottom = size;
	int mid;
	int ind = -1;

	while (top <= bottom) //until array is fully searched or element is found
	{
		 mid = (top+bottom)/2; //place mid at halfway point
		
		if(arr[mid]==valueToSearchFor) //Break out of loop if value found
		{
			ind = mid; 
			break;
		}
		else if (arr[mid]>valueToSearchFor) //change mid when mid is bigger than value
		{
			bottom=mid-1;
		}
		else //change of mid when mid is smaller than value
		{
			top=mid+1;
		}
	}

	return ind; //return index if found, or -1 if not found
		
}