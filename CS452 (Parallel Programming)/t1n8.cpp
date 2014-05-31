#include <iostream>
#include <stdio.h>
#include <string>
#include "mpi.h" // message passing interface
using namespace std;

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
	
	cout << "My branded id is " << my_rank << endl;
	
	// Know the problem parameters.
	int n = 300000;
	long int sum = 0;

	// Break the problem up.
	long int lsum = 0;
	int lstart = my_rank*(n/p);
	
	for (int x = lstart; x < lstart+(n/p); x++)
		lsum += x;
	
	// Put all them lsums together.
	if (my_rank != 0)
		MPI_Send(&lsum, 1, MPI_LONG_INT, 0, tag, MPI_COMM_WORLD);
	else {
		sum = lsum;
		long int tsum = 0;
		for (int x = 1; x < p; x++) {
			MPI_Recv(&tsum, 1, MPI_LONG_INT, x, MPI_ANY_TAG, MPI_COMM_WORLD, &status);
			sum += tsum;
		} // end for
		cout << sum << endl;
	} // end else

	// Shut down MPI
	MPI_Finalize();

	return 0;
}