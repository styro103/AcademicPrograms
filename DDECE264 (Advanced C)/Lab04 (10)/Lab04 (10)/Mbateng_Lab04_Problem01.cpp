/*ECE 264
  Lab 04
  Problem 01
  Shaun Mbateng
  This program takes two strings, and figures out if the second one is a substring, prefix, suffix
	in the string of the first.
*/

#include <stdio.h>
#include <string.h>
#include <iostream>
using namespace std;

int isSubString(char *str1, char *str2);
int isPrefix(char * str1, char * str2);
int isPostfix(char *str1, char *str2);
int isInString(char *str1, char *str2);

int main()
{
	//Character Arrays of String
	char string1[50];
	char string2[50];

	//Input Strings
	cout<<""<<endl;
	cout<<"What is string 1?"<<endl;
	cin>>string1;
	cout<<""<<endl;
	cout<<"What is string 2?"<<endl;
	cin>>string2;
	cout<<""<<endl;
	
	//Call Substring Function
	if(isSubString(string1,string2))
		printf("The second string is a substring of the first.\n");
	else
		printf("The second string is not a substring of the first.\n");

	//Call Prefix Function
	if(isPrefix(string1,string2))
		printf("The second string is the prefix of the first.\n");
	else
		printf("The second string is not the prefix of the first.\n");

	//Call Suffix Function
	if(isPostfix(string1,string2))
		printf("The second string is the suffix of the first.\n");
	else
		printf("The second string is not the suffix of the first.\n");

	//Call InStringFunction
	if(isInString(string1,string2))
		printf("All of the characters in the second string are in the first.\n");
	else
		printf("Not all of the characters in the second string are in the first.\n");

	cout<<""<<endl;

	return 0;
}

int isSubString(char * str1, char * str2) //Finds out if Substring
{
	for (int i=0; i<strlen(str1); i++)
	{
		int j;

		for (j=0; j<strlen(str2); j++)
		{
			if (str2[j]!=str1[i+j])
				break;
		}

		if (j==strlen(str2))
			return 1;
	}

	return 0;
}

int isPrefix(char * str1, char * str2) //Finds out if Prefix
{
	while(* str2 != 0)
	{
		if(* str2 != * str1)
			return 0;

		str2++;
		str1++;
	}

	return 1;
}

int isPostfix(char * str1, char * str2) //Finds out if Suffix
{
	for (int i=strlen(str1)-1; i>=strlen(str1)-strlen(str2); i--)
	{
		if (str2[i-strlen(str2)+1]!=str1[i])
			return 0;
	}

	return 1;
}

int isInString(char * str1, char * str2) //Finds out if Characters in string2 are in string1
{
	int count = 0;

	for (int i=0; i<strlen(str2); i++)
	{
		for (int j=0; j<strlen(str1); j++)
		{
			if (str2[i]==str1[j])
			{
				count++;
				break;
			}
		}
	}

	if (count==strlen(str2))
		return 1;
	else
		return 0;
}

