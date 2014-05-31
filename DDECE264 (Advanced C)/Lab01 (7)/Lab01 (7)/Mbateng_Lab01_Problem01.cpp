/*ECE 264
  Lab 01
  Problem 01
  Shaun Mbateng
  This program takes inputs into a character array until '$' is entered, displays it,
		inputs a new character, inserts it, and then display the array again
*/

#include <stdio.h>
#include <iostream>
using namespace std;

int main()
{
	char Sentence[100]; //100 Element Character Array "Sentence"
	char Single; //Character "Single"
	int i = 0;
	int j = 0;

	while (i<100) //Until Size of "Sentence"
	{
		cout<<"Enter element number "<<(i+1)<<":"<<endl; 
		cin>>Sentence[i]; //Enter Element
		if (Sentence[i] == '$') //If Element == '$'
			break; //Break out of Loop
		i++; //Increment i
	}

	for (j; j<=i; j++) //Start at Zero, Go Till i
		cout<<Sentence[j]; //Print "Sentence" in Single line

	cout<<""<<endl; //Put a 
	cout<<""<<endl;	//	Line Space

	cout<<"Enter another character:"<<endl;
	cin>>Single; //Enter Single

	//If "Sentence" Not Already Completely Filled
	if (i != 99)
	{
		for (i; i>0; i--)
		Sentence[i+1] = Sentence[i]; //Shift Elements of Array

		Sentence[0] = Single; //Make "Single" First Element

		for (i=0; i<=j; i++) //Start at Zero, Go Till j
			cout<<Sentence[j]; //Print "Sentence" in Single line
	}

	return 0;
}
