//*******************************************************************
// Program--Triangle Area
// Author: [Shaun Mbateng]
//Date: February 3, 2010 
//Session ????
//This programs asks for the base and height of a triangle, then finds 
// the area.
//*******************************************************************

#include <iostream.h>

int main()
{
	double b,h,A;
	char units[30];
		
	cout<<"What are the units? ";
	cin>> units;
	cout<<"How many "<<units<<" is the base of the triangle? ";
	cin>>b;
	cout<<"How many "<<units<<" is the height of the triangle? ";
	cin>>h;
	A=(0.5*b*h);
	cout<<"The area of the triangle is "<<A<< " " <<units<< " squared."<<endl;
	
	return 0;
}
