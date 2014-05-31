/*ECE 264
  Lab 04
  Problem 01
  Shaun Mbateng
  This program takes a string, reverses it, and then displays it
*/

#include <stdio.h>
#include <string.h>
#include <iostream>
using namespace std;

void str_reverse(char * str, int length);
void str_reverse_individual_words(char * str);

int main()
{
	//Character Array of Strings
	char list[500]; //Will Hold Original String and Individual Words Reversed String
	char rlist[500]; //Will Hold Reversed string

	cout<<""<<endl;
	cout<<"Enter String:"<<endl;
	gets(list);
	strcpy(rlist, list);
	

	cout<<""<<endl;
	cout<<"Original String:"<<endl;
	cout<<list<<endl; //Display Original String

	str_reverse(rlist, strlen(rlist)); //Call Reverse String Function
	str_reverse_individual_words(list); //Call Reverse Individual Words Function

	cout<<""<<endl;
	cout<<"Reversed String:"<<endl;
	cout<<rlist<<endl; //Display Reversed String
	cout<<""<<endl;
	cout<<"Reversed Individual Words String:"<<endl;
	cout<<list<<endl; //Display Reversed String
	cout<<""<<endl;
	
	return 0;
}

void str_reverse(char * str, int length)
{
	char temp;

	for (int i=0; i<length/2; i++) //Swap Characters
	{
		temp = str[i];
		str[i] = str[length-i-1];
		str[length-i-1] = temp;
	}
}

void str_reverse_individual_words(char * str) //Reverse Charcters in Words
{
	char substr1[500];
	char * substr2;
	char temp[500] = "\0";
	
	strcpy(substr1, str);

	while (substr2 != NULL)
	{
		substr2 = strstr(substr1, " ");
		if (substr2 == NULL)
			break;
		substr1[strlen(substr1)-strlen(substr2)] = '\0';
		str_reverse(substr1, strlen(substr1));
		strcat(temp, substr1);
		strcat(temp, " ");
		substr2++;
		strcpy(substr1, substr2);
	}
	
	str_reverse(substr1, strlen(substr1));
	strcat(temp, substr1);
	strcpy(str, temp);
}
