//**************************************************************************
// Final Project -- Movie Madness
// Author: [Shaun Mbateng]
//Date: April 29, 2010
//Session: Chen - 11:00 A.M. - Monday, Wednesday, Friday
//Passes A Message In 2 Rings, and Finds The Min, Max, and Average of a Seed
//**************************************************************************
#include <iostream>
#include <stdio.h>
#include <string.h>
#include <time.h>
#include "mpi.h" // message passing interface
using namespace std;

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
	
	//create a welcome message on each process
	sprintf(message, "You copyrighted Wizard of Oz! Sent from process %d,", my_rank);
	   
	//Even Number of CPU Processes
	if (p%2==0)
	{
		if (my_rank==0)
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, 2, tag, MPI_COMM_WORLD);
			MPI_Recv(message, 100, MPI_CHAR, p-2, tag, MPI_COMM_WORLD, &status);
		}
		else if (my_rank==p-2) 
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, 0, tag, MPI_COMM_WORLD);
			MPI_Recv(message, 100, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD, &status);
		}
	   else if (my_rank%2==0 && my_rank<p-1)
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, my_rank+2, tag, MPI_COMM_WORLD);
			MPI_Recv(message, 100, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD, &status);
		}
		if (my_rank==1)
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, p-1, tag, MPI_COMM_WORLD);
			MPI_Recv(message, 100, MPI_CHAR, my_rank+2, tag, MPI_COMM_WORLD, &status);
		}
		else if (my_rank==p-1) 
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, p-3, tag, MPI_COMM_WORLD);
			MPI_Recv(message, 100, MPI_CHAR, 1, tag, MPI_COMM_WORLD, &status);
		}
		else if (my_rank%2!=0 && my_rank<p-1 )
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD);
			MPI_Recv(message, 100, MPI_CHAR, my_rank+2, tag, MPI_COMM_WORLD, &status);
		}
	}
	
	//Odd Number of CPU Processes
	if (p%2!=0)
	{
		if (my_rank==0)
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, 2, tag, MPI_COMM_WORLD);
			MPI_Recv(message, 100, MPI_CHAR, p-1, tag, MPI_COMM_WORLD, &status);
		}	
		else if (my_rank==p-1) 
		{
		   MPI_Send(message, strlen(message)+1, MPI_CHAR, 0, tag, MPI_COMM_WORLD);
			MPI_Recv(message, 100, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD, &status);//2
		}
		else if (my_rank%2==0 && my_rank<p )
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, my_rank+2, tag, MPI_COMM_WORLD);
			MPI_Recv(message, 100, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD, &status);
		}
		if (my_rank==1)
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, p-2, tag, MPI_COMM_WORLD);
			MPI_Recv(message, 100, MPI_CHAR, my_rank+2, tag, MPI_COMM_WORLD, &status);
		}
		else if (my_rank==p-2) 
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, p-4, tag, MPI_COMM_WORLD);
			MPI_Recv(message, 100, MPI_CHAR, 1, tag, MPI_COMM_WORLD, &status);
		}
		else if (my_rank%2!=0 && my_rank<p)
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD);
			MPI_Recv(message, 100, MPI_CHAR, my_rank+2, tag, MPI_COMM_WORLD, &status);
		}
	}
	printf("%s received by process %d.\n", message, my_rank);
	
	int seed = 200;
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
	int local_a[500000];
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
	if (my_rank == 0)
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
