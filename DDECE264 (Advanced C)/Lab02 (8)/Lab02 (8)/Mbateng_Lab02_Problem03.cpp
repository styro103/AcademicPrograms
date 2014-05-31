/*ECE 264
  Lab 02
  Problem 03
  Shaun Mbateng
  This program takes three arrays, displays their address, sorts them,
	then displays them again.
*/

#include <stdio.h>
#include <iostream>
using namespace std;

void swap(int & a, int & b);
void sort3Integers(int & i1, int & i2, int & i3);

int main()
{
	//3 Integer Addresses
	int Address1;
	int Address2;
	int Address3;

	//Enter Integers & Assign Addresses
	cout<<"Enter integer number 1:"<<endl;
	cin>>Address1;
	cout<<endl;
	cout<<"Enter integer number 2:"<<endl;
	cin>>Address2;
	cout<<endl;
	cout<<"Enter integer number 3:"<<endl;
	cin>>Address3;
	cout<<endl;

	//Display Integers and Addresses Pre-Sorting
	cout<<"Pre-Sorting:"<<endl;
	cout<<"Address 1: "<<Address1<<endl;
	cout<<"Address 2: "<<Address2<<endl;
	cout<<"Address 3: "<<Address3<<endl;
	cout<<endl;

	sort3Integers(Address1, Address2, Address3); //Function to Sort Integers

	//Display Integers and Addresses Post-Sorting
	cout<<"Post-Sorting"<<endl;
	cout<<"Address 1: "<<Address1<<endl;
	cout<<"Address 2: "<<Address2<<endl;
	cout<<"Address 3: "<<Address3<<endl;

	return 0;
}

void sort3Integers(int & i1, int & i2, int & i3) //Sorting Function
{
	//Swap Booleans
	bool swap1;
	bool swap2 = true;
	
	do
	{
		swap1= false; //Set swap1 to false

		//If any of These True, swap1 Becomes True
		if (i1>i2)
		{
			swap(i1, i2);
			swap1 = true;
		}

		if (i2>i3)
		{
			swap(i2, i3);
			swap1 = true;
		}

		if (i1>i3)
		{
			swap(i1, i3);
			swap1 = true;
		}

		swap2 = swap1; //Make swap2 = swap1
	} while (swap2 == true); //Loop Until There Were No Swaps

}

void swap(int & a, int & b) //Swap Function
{
	int temp; //Integer to Temporarily Hold Values

	//Swap Values
	temp = a;
	a = b;
	b = temp;
}

