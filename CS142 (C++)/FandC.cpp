//*********************************************************
// Program 1--Farenheit and Centigrade
// Author: [Shaun Mbateng]
//Date: January 22, 2010
//Session ????
//This program asks for the temperature in farenheit,
// then converts it to centigrade, and if it is, says it's hot or cold.
//
//***********************************************************

#include <iostream.h>

int main()
{
	double f,c;

	cout<<"** Welcome to the UNWEDGE Weather Program ** "<<endl;
	cout<<"What is the temperature in Fahrenheit? ";
	cin>>f;
	c=(5.00/9.00)*(f-32);
	cout<<"Temperature in Centigrade is "<<c<< " degrees."<<endl;
//If Statements
if (f>=85)
	{
	cout<<"The temperature is hot "<<endl;
	cout<<"Have a nice hot day! "<<endl;
	}
	
else if (f<=20)
	{
	cout<<"The temperature is cold "<<endl;
	cout<<"Have a nice cold day! "<<endl;
	}
	
else	
	{
	cout<<"Have a nice day! "<<endl;
	}
	
	return 0;
}
