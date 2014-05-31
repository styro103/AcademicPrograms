#include <iostream.h>
#include <stdio.h>
#include <string.h>
#include <time.h>
#include "mpi.h" // message passing interface

int main (int argc, char * argv[]) {

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

	// I'm setting up a random array of numbers here, fixed to a set seed.
	// This will create the same set of random numbers, as long as the seed isn't changed.
	// I would recommend you copy this boilerplate down into a separate program to figure out what the max, min, and average are for this seed. 
	// Then you know what answer you should get from your parallel program.
	// Be sure to test your program for different seed values!!! (So you only need to change the seed, nothing else.)
	
	// For the final output, run your program for seed value 2109, 6667, and 31237 and tell me the output from these two seed runs.
	int seed = 200;
	srand(seed);
	const int n = 1000000;

	// The huge array is this one
	int a[n] = {0};
	for (int x = 0; x < n; x++)
		a[x] = rand();
	
	// Remember that your average has to be a decimal value, like a float or a double!!!
	// Also remember that you need to compute the minimum and maximum!

	// WRITE CODE HERE!!!!!

	
	// Shut down MPI
	MPI_Finalize();

	return 0;
}
