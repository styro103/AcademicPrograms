/*ECE 264
  Lab 03
  Problem 01
  Shaun Mbateng
  This program takes inputs into an integer array, displays the array (3 elements per line)
		then Displays the Range, Average, Minimum and Maximum
*/

#include <stdio.h>
#include <iostream>
using namespace std;

int range(int * arr, int size, int * average, int * p_min, int * p_max); //Range Function
void signs(int * arr, int size, int * p_zeros, int * p_neg, int * p_pos); //Signs Function

int main()
{
	int value[55];
	int value_size; //Size of Array
	int ran, ave,  min, max; //Integers for Range, Average, Minimum, and Maximum Respectively
	int zc = 0, nc = 0, pc = 0; //Integers for Zero Count, Negative Count, and Positive Count Respectively
	
	cout<<endl; //End Line
	
	for (int i=0; i<55; i++) //Until End of Array
	{
		cout<<"Enter array value number (Negative to End) "<<i+1<<":"<<endl; //Message to Enter Value
		cin>>value[i]; //Enter Temp Value
		cout<<endl; //Put Line Space
		value_size = i+1; //Size Will be i+1 (Counting from Zero)
		if (value[i]<0) //If Negative Value, Then Break
			break;
	}
	
	cout<<"Array (3 Elements Per Line): "<<endl;;

	for (int i=0; i<value_size; i++) //From start to size
	{
		cout<<value[i]<<" "; //Print Element and then a Space

		if ((i+1)%3 == 0) //If at 3rd Element
		{
			cout<<endl; //End Line
		}
	}
	
	min = value[0]; //Set Min to First Value
	max = value[0]; //Set Max to First Value
	
	ran = range(value, value_size, & ave, & min, & max); //Will Hold Range
	
	//Display Range, Average, Minimum, and Maximum Repsectively
	cout<<endl; //End Line
	cout<<"Range: "<<ran<<endl;
	cout<<"Average: "<<ave<<endl;
	cout<<"Minimum: "<<min<<endl;
	cout<<"Maximum: "<<max<<endl;
	cout<<endl; //End Line

	signs(value, value_size, & zc, & nc, & pc);

	//Display Zeros Count, Negatives Count, and Positives Count Respectively
	cout<<"Zeros Count: "<<zc<<endl;
	cout<<"Negatives Count: "<<nc<<endl;
	cout<<"Positives Count: "<<pc<<endl;
	cout<<endl; //End Line

	return 0;
}

int range(int * arr, int size, int * average, int * p_min, int * p_max)
{
	int ran; //Will Hold Range
	int sum = 0; //Will Hold Sum
	
	for (int i=0; i<size; i++) //Till Size of Array
	{
		sum+=arr[i]; //Increment Sum by Value of Element
		
		if (arr[i] < * p_min) //If Element is Less Than Current Minimum, Make New Minimum
			* p_min = arr[i];
		if (arr[i] > * p_max) //If Element is More Than Current Maximum, Make New Maximum
			* p_max = arr[i];
	}
	
	* average = sum/size; //Find Average
	ran = (* p_max)-(* p_min); //Find Range
	
	return  ran; //Return Range
}

void signs(int * arr, int size, int * p_zeros, int * p_neg, int * p_pos)
{	
	for (int i=0; i<size; i++) //Till Size of Array
	{
		//Depending on Element Value, Increment Count of Zeros, Negatives, or Positives
		if (arr[i] < 0)
		{
			* p_neg += 1; //Increment
		}
		if (arr[i] > 0)
		{
			* p_pos += 1; //Increment
		}
		if (arr[i] == 0)
		{
			* p_zeros += 1; //Increment
		}
	}
}
