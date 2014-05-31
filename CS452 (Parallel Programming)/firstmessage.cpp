#include <iostream.h>
#include <stdio.h>
#include <string.h>
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
	
	if (my_rank == 0) {
		sprintf(message, "yo shizzle");
		for (int dest = 1; dest < p; dest++)
			MPI_Send(message, strlen(message)+1, MPI_CHAR, dest, tag, MPI_COMM_WORLD);
		for (int source = 1; source < p; source++) {
			MPI_Recv(message, 100, MPI_CHAR, MPI_ANY_SOURCE, tag, MPI_COMM_WORLD, &status);
			printf("%s \n", message);
		} // end for
	} // end if
	else {
		MPI_Recv(message, 100, MPI_CHAR, 0, tag, MPI_COMM_WORLD, &status);
		sprintf(message, "go nizzle %d", my_rank);
		MPI_Send(message, strlen(message) + 1, MPI_CHAR, 0, tag, MPI_COMM_WORLD);
	} // end else
	
	
	
	
	
	
	
	/*
	if (my_rank == 0) {
		MPI_Send(message, strlen(message)+1, MPI_CHAR, 1, tag, MPI_COMM_WORLD);
		MPI_Recv(message, 100, MPI_CHAR, p-1, tag, MPI_COMM_WORLD, &status);
	}
	else if (my_rank == p-1) {
		MPI_Recv(message, 100, MPI_CHAR, my_rank-1, tag, MPI_COMM_WORLD, &status);
		MPI_Send(message, strlen(message)+1, MPI_CHAR, 0, tag, MPI_COMM_WORLD);	
	}
	else {
		MPI_Recv(message, 100, MPI_CHAR, my_rank-1, tag, MPI_COMM_WORLD, &status);
		MPI_Send(message, strlen(message)+1, MPI_CHAR, my_rank+1, tag, MPI_COMM_WORLD);
	}
	*/
	
	// printf("%s printed by process %d\n", message, my_rank);

	// Shut down MPI
	MPI_Finalize();

	return 0;
}
