//Turkeys Program
//Shaun Mbateng
//CS-142 Test #3 No. 8 (15 Points)

#include <iostream.h>

int serves(double);
void ReadList(double[],int &);
void Avg(double[], int);
void Total(double[],int);
int a;

int main()
{
	double A[100];
	int len;
	
	ReadList(A, len);
	Avg(A, len);
	Total(A,len);
	
	return 0;
}

int serves(double wt)
{
	return int(1.5*(wt-8)+4);
}

void ReadList(double A[], int & len)
{
	cout<<"How many turkeys?"<<endl;
	cin>>len;
	for (int i=0;i<len;i++)
	{
		cout<<"Enter the "<<i+1<<" turkey weight."<<endl;
		cin>>A[i];
	}
}

void Avg(double A[], int len)
{
	double sum, average;
	sum=0;
		for (int i=0;i<len;i++)
		{
			sum=sum+A[i];
		}
	cout<<"The average turkey weight is "<<sum/len<<" pounds."<<endl;
}

void Total(double A[], int len)
{
	double wt, people;
	wt=0;
		for (int i=0;i<len;i++)
		{
			wt=wt+A[i];
		}
		cout<<"The number of people served is "<<serves(wt)<<" people."<<endl;
}
