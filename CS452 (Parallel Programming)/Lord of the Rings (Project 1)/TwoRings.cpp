/*
Shaun Mbateng & Chris Johnson
CS 452 - ParaHell Programming
Project 1: Lord of the Rings
Part 1: Two Rings
This Program Sends a Message in A Specific Ring Order
*/

#include <iostream>
#include <stdio.h>   //required for sprintf function
#include <string.h>
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
	
	//Ring thing
	
	//Create a message (using C)
	sprintf(message, "Process %d", my_rank); //First Part of Message
	
	if (my_rank == 0) //If Rank is 0
	{
		if (p%2 == 0) //If p is Even
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, 2, tag, MPI_COMM_WORLD); //Send to Process 2
			MPI_Recv(message, 100, MPI_CHAR, p-2, tag, MPI_COMM_WORLD, &status); //Receive From Process That's 2 Less Than p
		}
		
		else if (p%2 != 0) //If p is Odd
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, 2, tag, MPI_COMM_WORLD); //Send to Process 2
			MPI_Recv(message, 100, MPI_CHAR, p-1, tag, MPI_COMM_WORLD, &status); //Receive From Process That's 1 Less Than p	
		}
	}
	
	else if (my_rank == 1) //If Rank is 1
	{
		if (p%2 == 0) //If p is Even
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, p-1, tag, MPI_COMM_WORLD); //Send to Process That's 1 Less Than p
			MPI_Recv(message, 100, MPI_CHAR, 3, tag, MPI_COMM_WORLD, &status); //Receive From Process 3
		}
		
		else if (p%2 != 0) //If p is Odd
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, p-2, tag, MPI_COMM_WORLD); //Send to Process That's 2 Less Than p
			MPI_Recv(message, 100, MPI_CHAR, 3, tag, MPI_COMM_WORLD, &status); //Receive From Process 3
		}
	}
	
	else if (my_rank == p-2) //If Rank is 2 Less Than p
	{
		if (p%2 == 0) //If p is Even
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, 0, tag, MPI_COMM_WORLD); //Send to Process 0
			MPI_Recv(message, 100, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD, &status); //Receive From Process That's 2 Less
		}
		
		else if (p%2 != 0) //If p is Odd
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD); //Send to Process That's 2 Less
			MPI_Recv(message, 100, MPI_CHAR, 1, tag, MPI_COMM_WORLD, &status); //Receive From Process 1
		}
	}
	
	else if (my_rank == p-1) //If Rank is 1 Less Than p
	{
		if (p%2 == 0) //If p is Even
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD); //Send to Process That's 2 Less
			MPI_Recv(message, 100, MPI_CHAR, 1, tag, MPI_COMM_WORLD, &status); //Receive From Process 1
		}
		
		else if (p%2 != 0) //If p is Odd
		{
			MPI_Send(message, strlen(message)+1, MPI_CHAR, 0, tag, MPI_COMM_WORLD); //Send to Process 0
			MPI_Recv(message, 100, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD, &status); //Receive From Process That's 2 Less
		}
	}
	
	else if (my_rank%2 == 0) //If Rank is Even
	{
		MPI_Send(message, strlen(message)+1, MPI_CHAR, my_rank+2, tag, MPI_COMM_WORLD); //Send to Process That's 2 More
		MPI_Recv(message, 100, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD, &status); //Receive From Process That 2 Less
	}
	
	else if (my_rank%2 != 0) 
	{
	    MPI_Send(message, strlen(message)+1, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD);//Send to Process That's 2 Less
		MPI_Recv(message, 100, MPI_CHAR, my_rank+2, tag, MPI_COMM_WORLD, &status); //Receive From Process That 2 More
	}
	
	printf("%s tells Process %d", message, my_rank); //Second Part of Message
	cout<<" that the only thing smaller than Frodo is his...IQ!"<<endl; //Third and Last Part of Message (Cruel Frodo Message)
	
	// Shut down MPI
	MPI_Finalize();

	return 0; //Return 0
}
