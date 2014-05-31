/*ECE 264
  Lab 03
  Problem 03
  Shaun Mbateng
  Does Lab 5 Problem 1, but With One Function
*/

#include <stdio.h>
#include <math.h>
#include <iostream>
using namespace std;

void sum(double x, int n, double * sum1, double  * sum2); //Sums Function

int main()
{
	double sum1 = 0; //Initialize sum1 to Zero
	double sum2 = 0; //Initialize sum2 to Zero
	double x; //Number
	int n; //Number of Terms

	//Input x and n Values
	cout<<endl;
	cout<<"What is x?"<<endl;
	cin>>x;
	cout<<endl;
	cout<<"What is n?"<<endl;
	cin>>n;
	cout<<endl;

	sum(x, n, & sum1, & sum2); //Call Sums Function

	//Display Sums
	cout<<"Sum 1: "<<sum1<<endl;
	cout<<"Sum 2: "<<sum2<<endl;
	cout<<endl;

	return 0;
}

void sum(double x, int n, double * sum1, double  *sum2) //Sums Function
{	
	//For Loop to Add Power of Sums
	for (int i = 0; i<=n; i++) //From Zero to n
	{
		* sum1 += pow(x,i); //Add x^i to sum1

		if (i%2 == 0) //If i is Even
			* sum2 += pow(x,i); //Add x^i to sum2
		if (i%2 != 0) //If i is Odd
			* sum2 -= pow(x,i); //Subtract x^i From sum2
	}
}
