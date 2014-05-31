//*******************************************************************
// Project 3--Roman Numerals
// Author: [Shaun Mbateng]
//Date: February 19, 2010 
//This programs asks for a regular number, then changes it and shows
//its roman numerals with subtractions.
//*******************************************************************

#include <iostream>
using namespace std;

int main()
{
	int n;
	int a,b,c,d;
	int i;
	char Y='y';
	
	/*Bases:
		I=1
		V=5
		X=10
		L=50
		C=100
		D=500
		M=1000
	Subtractions:
		IV=4
		IX=9
		XL=40
		XC=90
		CD=400
		CM=900
		CMXC=990
		CMXCIX=999
		MCMXCIX=1,999
	*/

	do{
	
	//Client
	cout<<""<<endl;
	cout<<"Hello Mr. Rabbit's client(s)."<<endl;
	cout<<endl;
	cout<<"Enter the number of how many you want."<<endl;
	cin>>n;
	cout<<""<<endl;
	cout<<""<<endl;
	
	if (n>9999 || n<=0)
	{
		cout<<"Sorry, but we only do orders must be between 1 and 9999."<<endl;
		cout<<""<<endl;
		cout<<""<<endl;
		cout<<"Would you like to place another order? (y/n) ";
		cin>>Y;
		cout<<""<<endl;
	}	
	
	else if (n<=9999 && n>0)
	{
		cout<<"I will inform Mr. Rabbit."<<endl;
		cout<<""<<endl;
		cout<<""<<endl;
		
		//Mr. Rabbit
		cout<<"Mr. Rabbit, the amount your client(s) want(s) is: "<<endl;
		
		//Conversion
		a=(n/1000);
		b=(n-a*1000)/100;
		c=((n-a*1000)-(b*100))/10;
		d=(n-a*1000)-(b*100)-(c*10);
		
		//Simple Roman Numeral:
		cout<<"Simple Roman Numeral Form: ";
			if (a==5)
			{
				cout<<"(V)";
			}
			else if (a>5 && a<10)
			{
				cout<<"(V";
				int i=0;
				while (i<a-5)
				{	
					i++;
					cout<<"I";
				}
				cout<<")";
			}
			else
				for (i=0;i<a;i++)
				{
					cout<<"M";
				}
			if (b==5)
			{
				cout<<"D";
			}
			else if (b>5 && b<10)
			{
				cout<<"D";
				int i=0;
				while (i<b-5)
				{	
					i++;
					cout<<"C";
				}
			}
			else
				for (i=0;i<b;i++)
				{
					cout<<"C";
				}
			if (c==5)
			{
				cout<<"L";
			}
			else if (c>5 && c<10)
			{
				cout<<"L";
				int i=0;
				while (i<c-5)
				{	
					i++;
					cout<<"X";
				}
			}
			else
				for (i=0;i<c;i++)
				{
					cout<<"X";
				}
			if (d==5)
			{
				cout<<"V";
			}
			else if (d>5 && d<10)
			{
				cout<<"V";
				int i=0;
				while (i<d-5)
				{	
					i++;
					cout<<"I";
				}
			}
			else
			{
				for (i=0;i<d;i++)
					cout<<"I";
			}
		
		cout<<""<<endl;
		
		//Roman Numeral Form:
		cout<<"Roman Numeral Form: ";
			if (a==4)
			{	
				cout<<"(IV)";
			}
			else if (a==5)
			{
				cout<<"(V)";
			}
			else if (a==9)
			{
				cout<<"(IX)";
			}
			else if (a>5 && a<9)
			{
				cout<<"(V";
				int i=0;
				while (i<a-5)
				{	
					i++;
					cout<<"I";
				}
				cout<<")";
			}
			else
				for (i=0;i<a;i++)
				{
					cout<<"M";
				}
		if (b==4)
			{	
				cout<<"CD";
			}
			else if (b==5)
			{
				cout<<"D";
			}
			else if (b==9)
			{
				cout<<"CM";
			}
			else if (b>5 && b<9)
			{
				cout<<"D";
				int i=0;
				while (i<b-5)
				{	
					i++;
					cout<<"C";
				}
			}
			else
				for (i=0;i<b;i++)
				{
					cout<<"C";
				}
		if (c==4)
			{	
				cout<<"XL";
			}
			else if (c==5)
			{
				cout<<"L";
			}
			else if (c==9)
			{
				cout<<"XC";
			}
			else if (c>5 && c<9)
			{
				cout<<"L";
				int i=0;
				while (i<c-5)
				{	
					i++;
					cout<<"X";
				}
			}
			else
				for (i=0;i<c;i++)
				{
					cout<<"X";
				}
		if (d==4)
			{	
				cout<<"IV";
			}
			else if (d==5)
			{
				cout<<"V";
			}
			else if (d==9)
			{
				cout<<"IX";
			}
			else if (d>5 && d<9)
			{
				cout<<"V";
				int i=0;
				while (i<d-5)
				{	
					i++;
					cout<<"I";
				}
			}
			else
			{	
				for (i=0;i<d;i++)
					cout<<"I";
			}
	
	cout<<""<<endl;
	cout<<""<<endl;
	cout<<"Hello again Mr. Rabbit's client(s)."<<endl;
	cout<<"Would you like to place another order? (y/n) ";
	cin>>Y;
	cout<<""<<endl;
	}
	
	}while (Y=='y');
	
	
	return 0;
}
