/*
**************************************************
Average Program
Shaun Mbateng
April 29, 2010
This programs has the user input a list,
	then it tells the list's sum and average
**************************************************
*/

#include <iostream.h>

int main()
{
	int i=1;
	int sum=0;
	int n;
	double ave;
	int o=1;
	cout<<"Enter the number of positive integers in this list. ";
	cin>>n;
	while (o<=n)
	{
		cout<<"Enter list integer number "<<o<<" ";
		cin>>i;
		sum=sum+i;
		i++;
		o++;
	}
	ave=sum/n;
	cout<<"The numbers' sum is "<<sum<<", and their average is "<<ave<<" remainder "<<sum%n<<"."<<endl;
	
	return 0;
}
