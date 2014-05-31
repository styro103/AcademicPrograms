//maxArray Program
//Shaun Mbateng
//CS-142 Test #3 No. 5 (14 Points)

#include <iostream.h>

void maxArray();
int A[100];

int main()
{
	maxArray();
	cout<<""<<endl;
	cout<<"The largest number is "<<A[0]<<endl;
	
	return 0;
}

void maxArray()
{
	int i,n;
	cout<<""<<endl;
	cout<<"How many numbers?"<<endl;
	cin>>n;
	int max=A[0];
	for (i=0;i<n;i++)
	{
		cout<<"Enter the "<<i+1<<" number in the list."<<endl;
		cin>>A[i];
		if (max<A[i])
		{
			max=A[i];
			A[0]=A[i];
		}
		else
		{
			max=A[0];
		}
	}
	
}
