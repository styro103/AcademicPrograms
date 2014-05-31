#include <iostream>
#include <stdlib.h>
#include <string.h>
using namespace std;

int recUpper(char * str, int & count, int size); //Question 1
int dacUpper(char str [], int & count, int start, int stop); //Question 2
void dynUpper(char * str, int & count, int size); //Question 3

int main()
{
	//Character Arrays of String
	char str[50];
	int uc = 0;
	int size;
	
	//Input Strings
	cout<<""<<endl;
	cout<<"What is the string?"<<endl;
	cin.getline(str,50);
	size = strlen(str);
	
	uc = recUpper(str, uc, size);
	
	cout<<""<<endl;
	cout<<"The string is: ";
	cout<<str<<endl;
	cout<<"The number of upper case letter using recursion is: ";
	cout<<uc<<endl;
	uc = 0;
	
	/* uc = */ dynUpper(str, uc, size);
	cout<<"The number of upper case letter using dynamic programming is: ";
	cout<<uc<<endl;
	uc = 0;
	
	uc = dacUpper(str, uc, 0, strlen(str));
	cout<<"The number of upper case letter using divide-and-conquer is: ";
	cout<<uc<<endl;
	cout<<""<<endl;
	
	return 0;
}

int recUpper(char * str, int & count, int size) //Recursion
{	
	if(size == 0) 
		return count;
	
	if (*str >= 'A' && *str <= 'Z')
		count++;
		
     return recUpper(++str, count, size-1);
}

int dacUpper(char str [], int & count, int start, int stop) //Divide-and-Conquer
{	
	if (start>stop)
		return count;
	
	int mid = (start+stop)/2;
	
	if (str[mid] >= 'A' && str[mid] <= 'Z')
			count++;
	
	dacUpper(str, count, start, mid-1);
	dacUpper(str, count, mid+1, stop);
	
	return count;
}

void dynUpper(char * str, int & count, int size)
{

}

