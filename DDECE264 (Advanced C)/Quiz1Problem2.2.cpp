#include <stdio.h>
#include <iostream.h>

//Part 2 Problem 2

int main()
{
	int K[  ]= {1,2,3,4,5,6};
	int sum = 0; 
	int i;
	int * q; 

	q = K;
	
	cout<<endl;
	cout<<"initial sum: "<<sum<<endl;
	cout<<"initial q: "<<q<<endl;

	for(i=0;i<3;i++)
	{
		sum=sum+*q;
		cout<<"sum "<<i+1<<": "<<sum<<endl;
	    q+=2;
		cout<<"q"<<i+1<<": "<<q<<endl;
	}
	
	cout<<"final sum: "<<sum<<endl;
	cout<<"final q: "<<q<<endl;
	cout<<endl;

	return 0;
}
