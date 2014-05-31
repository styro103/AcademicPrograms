/*ECE 264
  Lab 02
  Problem 01
  Shaun Mbateng
  This program takes inputs into an integer array, displays the array (with a certain
	number of elements per line. Gets another integer, then displays the array staring 
	from the other integer
*/

#include <stdio.h>
#include <iostream>
using namespace std;

void printArray(int arr[], int start, int size, int L); //Function to Print Array

int main()
{
	char run = 'y'; //Character to Loop Program

	do
	{
		int value[55]; //Array of Integers
		int value_size; //Size of Array
		int line_size = 0; //Integer to Determine How Many Values to Display in a Line
		int k = 999; //Element to start From

		for (int i=0; i<55; i++) //Until End of Array
		{
			cout<<"Enter array value number "<<i+1<<":"<<endl; //Message to Enter Value
			cin>>value[i]; //Enter Value
			cout<<endl; //Put Line Space
			value_size = i+1; //Size Will be i+1 (Counting from Zero)
			if (value[i]<0) //If Negative Value, Then Break
				break;
		}

		while (line_size<1 || line_size>10) //Loop Until Line Size is Between 1 and 10
		{
			cout<<"How many elements per line should be displayed? (Must be from 1 to 10)"<<endl;
			cin>>line_size;
			cout<<endl;
		}

		printArray(value, 0, value_size, line_size); //Print Array, Start at Element 0, Print line_size Elements per Line

		cout<<endl; //Line Space
		cout<<endl; //Line Space

		while (k>value_size || k<1) //Start Element Must be Smaller Than Size of Array and Bigger Than 1
		{
			cout<<"Enter the kth value to display array from: (Must be from 1 to Array Size)"<<endl;
			cin>>k;
			cout<<endl;
		}
	
		printArray(value, (k-1), value_size, value_size); //Print Array, Start at Element k-1, Print in Single Line

		cout<<"Run program again? (y/n)"<<endl; //Ask to Run Again
		cin>>run; //Input run character
		cout<<endl; //Line Space

		while (run !='y' && run!='n') //Answer Must be y or n
		{
			cout<<"Run again? (Answer must be y/n)"<<endl;
			cin>>run;
			cout<<endl;
		}

	} while (run == 'y'); //When run !=y, Program Stops

	return 0;
}

void printArray(int arr[], int start, int size, int L)
{
	for (int i=start; i<size; i++) //From start to size
	{
		cout<<arr[i]<<" "; //Print Element and then a Space
		if ((i+1)%L == 0) //If at Lth Element
		{
			cout<<endl; //End Line
			cout<<endl; //Line Space
		}
	}
}