/*ECE 264
  Lab 04
  Problem 02
  Shaun Mbateng
  This program removes all occurences of one string from another.
*/

#include <stdio.h>
#include <string.h>
#include <algorithm>
#include <iostream>
using namespace std;

void str_remove(char * str1, char * str2);

int main()
{
	//Character Arrays of String
	char list1[500];
	char list2[20];
	
	//Input Strings
	cout<<""<<endl;
	cout<<"What is string 1?"<<endl;
	gets(list1);
	cout<<""<<endl;
	cout<<"What is string 2?"<<endl;
	gets(list2);
	cout<<""<<endl;

	cout<<"Original String:"<<endl;
	cout<<list1<<endl;

	str_remove(list1, list2); //Call Remove Occurences Function

	cout<<""<<endl;
	cout<<"String w/ Removed Occurences:"<<endl;
	cout<<list1<<endl;
	cout<<""<<endl;

	return 0;
}

void str_remove(char * str1, char * str2) //Remove Occurences
{   
	char substr1[500];
	char * substr2 = "temporary string";
	char temp[500] = "\0";
	int count = 1;
	
	strcpy(substr1, str1);
	
	while (substr2 != NULL)
	{
		substr2 = strstr(substr1, str2);
		if (substr2 == NULL)
			break;
		substr1[strlen(substr1)-strlen(substr2)] = '\0';
		strcat(temp, substr1);
		substr2 += strlen(str2);
		strcpy(substr1, substr2);
	}
	
	strcat(temp, substr1);
	strcpy(str1, temp);
}
