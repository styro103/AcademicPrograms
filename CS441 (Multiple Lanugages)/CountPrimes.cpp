/* 
Shaun Mbateng
CS 441 - J. Sorenson
MPI Counting Primes
April 21, 2014 
*/

#include <iostream>
#include <cmath>
#include "mpi.h"

using namespace std;

int main (int argc, char * argv[]);
int prime_number (int n, int id, int np);

int main (int argc, char * argv[])
{
	int id; //For Rank
	int n; //Number to Count to
	int np; //Number of Processes
	int primes; //Big Number of Primes (For MPI Reduce)
	int primes_count; //Number of Primes

	MPI_Init(&argc,&argv); // start up MPI
	MPI_Comm_size(MPI_COMM_WORLD, &np); // get number of processors
	MPI_Comm_rank(MPI_COMM_WORLD, &id); // get my ID number

	if(id==0) // Enter Number to Count To
	{
		cout <<""<<endl;
		cout<<"***Prime Number Counter***"<<endl;
		cout << "Please enter n: ";
		cin >> n;
	}
	
	MPI_Bcast(&n,1,MPI_INT,0,MPI_COMM_WORLD); // share n with broadcast

	primes_count = prime_number(n, id, np); //Get Number of Primes

	MPI_Reduce(&primes_count, &primes, 1, MPI_INT, MPI_SUM,0,MPI_COMM_WORLD); //Reduce Number of Primes to "primes" Variable

	if (id == 0) //Display Value of n, and Number of Primes
	{
		cout <<""<<endl;
		cout <<"Number of Processors = "<<np<<endl;
		cout << "n = " << n <<endl; 
		cout << "No. of Primes = "<<primes<<endl;
		cout <<""<<endl;
	}

	MPI_Finalize(); // done!
	
	return 0;
}

int prime_number(int n, int id, int np) //Function That Returns Number of Primes by Striping
{
	int count = 0; //Integer to Hold Count of Primes, Initialized to Zero

	for (int i = 2 + id; i <= n; i = i + np) // Count Primes with Striping
	{		
		//These Were Added to Make the Program Do Less Searching, and Run Faster
		
		if (i % 2 == 0 && np % 2 == 0 && i > 2) //If i is Even, and so is np, and i>2
			break; //Break Out of Loop, All Following i's Will be Even, and Thus Not Prime
		
		if (i % 2 == 0 && i > 2) //If i is Even and Greater Than 2, Not Prime, Go to Next Loop Iteration
			continue;
			
		int prime = 1; //Integer to Test Whether Prime or Not, Initialized to 1
			
		for (int j = 2; j <= sqrt(i); j++) //From 2 till Square Root of i
		{
			if ((i % j) == 0) //Check if Evenly Divides
			{
				prime = 0; //If So Break
				break;
			}
		}
			
		count += prime; //Increment Count if Necessary
	}
	
	return count; //Return Count
}


/* 
--Sample Run--

***Prime Number Counter***
Please enter n: 1000000000

Number of Processors = 32
n = 1000000000
No. of Primes = 50847534 

*/

