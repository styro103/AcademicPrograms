# include <iostream.h>

int main()
{
	int sum=0;
	int i;
	int n;
	cout<<"What is the last term?"<<endl;
	cin>>n;
	for (i=1;i<=n;i++)
	{
		sum=sum+i;
	}
	cout<<"The sum of the numbers from 1 to "<<n<<" is "<<sum<<endl;
	
	return 0;
}
