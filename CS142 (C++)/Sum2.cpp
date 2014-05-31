#include <iostream.h>
#include <stdio.h>
#include <string.h>
#include "mpi.h" // message passing interface

int main (int argc, char * argv[]) 
{
	int my_rank;			// my CPU number for this process
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
	// Know the problem.
	int n = 1000000;
	int sum = 0;	
	// Break it up.
	int local_n = n/p;
	int local_start = my_rank * local_n;
	
	// Do the work for each process.
	int local_sum = 0;
	for (int x = local_start; x < local_start + local_n; x++)
		local_sum += x;		
	// Putting the results together.
	if (my_rank != 0) 
	{
		MPI_Send(&local_sum, 1, MPI_INT, 0, tag, MPI_COMM_WORLD);
	}
	else 
	{
		sum = local_sum;
		int temp_sum = 0;
		for (int x = 1; x < p; x++) 
		{
			MPI_Recv(&temp_sum, 1, MPI_INT, x, tag, MPI_COMM_WORLD, &status);
			sum += temp_sum; // like dim sum
		}
		cout << "The total is " << sum << endl;			
	}	
	// Shut down MPI
	MPI_Finalize();
	return 0;
}

