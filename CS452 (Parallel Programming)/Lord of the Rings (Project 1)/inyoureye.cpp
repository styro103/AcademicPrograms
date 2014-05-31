#include <iostream.h>
#include <stdio.h>   //required for sprintf function
#include <string.h>
#include <fstream.h>
#include "mpi.h" // message passing interface

/*
Shaun Mbateng & Chris Johnson
CS 452 - ParaHell Programming
Project 1: Lord of the Rings
Part 1: Two Rings
This Program Sends a Message in A Specific Ring Order
*/

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
	
	
	
	int letter[26]={0};
	int letterA[26]={0};
	int counter=0;
	int MAX=10000;
	char data[10000];
	if(my_rank==0)
	{
		char Alpha;
		ifstream infile, oinfile;
		infile.open("eyetext.txt");
		while(!infile.eof())
		{	
			infile>> Alpha;
			counter++;
			
		}
		counter--;
		infile.close();
		oinfile.open("eyetext.txt");
		int x = 0;
		while(!oinfile.eof())
		{
			oinfile >> data[x++];
			//oinfile.getline(data, MAX);
		}
		oinfile.close();
		
		for(int i=0; i<20; i++)
		{
			cout<<data[i];
		}
		cout << endl;
		//cout<<strlen(data);
		cout<<"The size of the string is "<< counter<<endl;
		cout<<"split up by "<<(counter/p)<<endl;
		//
	
	}
	
	char * rbuf = new char[counter/p];
	//MPI_Scatter(data, (counter/p) , MPI_CHAR, rbuf, (counter/p) , MPI_CHAR, 0, MPI_COMM_WORLD);
	MPI_Scatter(data, counter , MPI_CHAR, rbuf, counter , MPI_CHAR, 0, MPI_COMM_WORLD);
	
	/*
	if (my_rank==2)
	{
		for(int i=0; i<200; i++)
		{
			cout<<rbuf[i];
		}
	}
	*/
	
	for(int i=0; i<counter; i++)
	{
		letter[rbuf[i]-97]++;
	}
	
	
	/*
	
	if(my_rank=2)
	{
		for(int i=0; i<counter/p; i++)
		{
			cout<< rbuf[i]<<endl;
		}
	
	}
	cout<<endl;
	*/
	
	// At this point, each process has its own information in its letter array.
	
	// mpi gather
	// would it be an int?
	
	MPI_Allreduce(letter, letterA, 26, MPI_INT, MPI_SUM, MPI_COMM_WORLD);
	
	int check=0;
	if(my_rank==0)
	{
		for(int i=0; i<26; i++)
		{
			cout<< char (i+97) << ": " << letterA[i]<<endl;
			check+=letterA[i];
		}
	}
	
	if(my_rank==0)
	{
		cout<<check<<endl;
	}
	
	
	
	delete rbuf;
	// Shut down MPI
	MPI_Finalize();

	return 0; //Return 0
}

