#include <iostream.h>
#include <stdio.h>   //required for sprintf function
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
	
	//create a welcome message on each process
	if (my_rank==0)
	   sprintf(message, "Hello World! from process %d", my_rank);
	   
	//Send this message to all other processes
	if (my_rank==0){
	   for (int i=1; i<p; i++) {
	     dest =i;
		 tag=i;
		 MPI_Send(message, 100, MPI_CHAR, dest, tag, MPI_COMM_WORLD);	 
		 
		 //strlen(messsage)+1 for 100 above
	   }
	} else {
	   //Receive the sent message at all processes except 0
	   source=0;
	   tag=my_rank;
	   MPI_Recv(message, 100, MPI_CHAR, source, tag, MPI_COMM_WORLD, &status);
	   }
	   // print the received message on all process except 0
	   if (my_rank!=0){
	    cout<<"Message received on proc "<<my_rank<<": "<<message<<endl;
	   }
	
	
	// Shut down MPI
	MPI_Finalize();

	return 0;
}
