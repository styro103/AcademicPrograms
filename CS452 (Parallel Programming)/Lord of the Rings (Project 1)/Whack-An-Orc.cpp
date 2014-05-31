/*
Shaun Mbateng & Chris Johnson
CS 452 - ParaHell Programming
Project 1: Lord of the Rings
Part 2: Whack-An-Orc
This Program Gives the Minimum, Average, and Maximum of an Array of Integers
*/

#include <iostream.h>
#include <stdio.h>
#include <string.h>
#include "mpi.h" // message passing interface

int main (int argc, char * argv[]) 
{
	int my_rank;			// my CPU number for processes
	int p;					// number of CPUs that we have
	int source;				// rank of the sender
	int dest;				// rank of destination
	int tag = 0;			// message number
	char message[100];		// message itself
	MPI_Status status;		// return status for receive
	
	// Start MPI
	MPI_Init(&argc, &argv);
	
	// Find out my rank!
	MPI_Comm_rank(MPI_COMM_WORLD, &my_rank);
	
	// Find out the number of processes!
	MPI_Comm_size(MPI_COMM_WORLD, &p);
	
	// THE REAL PROGRAM IS HERE
	
	// WRITE CODE HERE!!!!!
	
	int seed = 1251; //Seed Generator With Number 1251
	srand(seed);
	const int n = 1000000;
	// The huge array is this one
	int a[n] = {0};
	for (int x=0; x<n; x++)
		a[x] = rand();
 
	// Remember that your average has to be a decimal value, like a float or a double!!!
	// Also remember that you need to compute the minimum and maximum!
	// WRITE CODE HERE!!!!!
	// Break it up.
	int local_n = n/p;
	int local_start = local_n * my_rank;
	int local_a[n];
	// SCATTER~!!!!
	MPI_Scatter(&a[0], local_n, MPI_INT, local_a, local_n, MPI_INT, 0, MPI_COMM_WORLD);

	//Do our local work.
	//temp is set to zero and will take the highest value in the array.
	int temp=0;
	for (int x=0; x<local_n; x++)
	{
		if (local_a[x]>temp)
		{
			temp =local_a[x];
		}
	}
	//max is where the MPI_MAX is being sent to.
	int max=0;
 
	MPI_Reduce(&temp, &max, 1, MPI_INT, MPI_MAX,0, MPI_COMM_WORLD);
	//This makes it so it only prints out the max value once.
	if (my_rank == 0) //Reduces Back to Process 0
		cout<<"The maximum is "<<max<<endl;
 
	//temp2 is set to the max value so that it can compare and find the min.
	int temp2=max;
	for (int y=0; y<local_n; y++)
	{
		if (local_a[y]<temp2)
		{
			temp2=local_a[y];
		}
	}
	//temp2 becomes the smallest value in the array.
	int min =0;
	//min is where it's being sent to.
	MPI_Reduce (&temp2, &min, 1, MPI_INT, MPI_MIN,0, MPI_COMM_WORLD);
 
	if (my_rank ==0)
		cout<<"The minimum is "<< min<<endl;
	//the double sum is where the local_sum value is being sent to.
	//the local_sum is where the sum of all of the arrays is found.
	double sum=0;
	double local_sum=0;
	for (int x=0; x<local_n; x++) 
	{
		local_sum+=a[x];
	}
	//this is what calculates the sum of the array.
	MPI_Reduce (&local_sum, &sum, 1, MPI_DOUBLE, MPI_SUM, 0, MPI_COMM_WORLD);
	//this is the average variable that calculates the average from the sum.
	double ave= sum/n;
	if (my_rank==0)
		cout<<"The average is "<< ave <<endl; 

	// Shut down MPI
	MPI_Finalize();

	return 0;
}
