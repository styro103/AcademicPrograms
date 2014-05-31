#include <iostream.h>
#include <stdio.h>
#include <string.h>
#include <time.h>
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

	// WRITE CODE HERE!!!!!

	
	// Shut down MPI
	MPI_Finalize();

	return 0;
}
