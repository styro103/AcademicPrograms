//Chris Johnson
//Merge Sort

#include <iostream>
#include <stdio.h>
#include <string.h>
#include <fstream.h>
#include <algorithm>
#include "mpi.h"

using namespace std;

//void merge(long, long, long);
//void mergesort(long, long);

int main(int argc, char * argv[])
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
	
	long SizetoProcess, root=0, currentSize=10;
	//long* SortArray= NULL, *tempArray= NULL, *resultArray=NULL;
	
	
	
	// process 0 needs to read this part in.
	
		//reads in file
		ifstream infile;
		ofstream outfile;
		infile.open("example.txt");
		//sets up size of array by reading in the first
		//number of the text file.
		long n;
		infile >> n;
		//fills array with the rest of text file
		long Array [n];
		long x=0;
		while(!infile.eof())
		{
			infile >> Array[x++];
		}
	
	
		long processor=p;
		long columns=(n/processor);
	
	/*
	//create the structure
	
	long* Tree = new long[n];
	long step=1;
	while(step<n)
	{
		step*=2;
	}
	for(; step>0; step/=2)
	{
		for(long process=0; (process+ step)<n; process+=(2*step))
		{
			Tree[process+ step]=process;
		}
	}
	
	if(my_rank==root)
	{
		SizetoProcess=10;
	}
	
	MPI_Bcast(&SizetoProcess, 1, MPI_LONG, root, MPI_COMM_WORLD);
	
	currentSize=SizetoProcess;
	//SortArray= new long[currentSize];
	//tempArray= new long[currentSize];
	*/
	
	/*
	for(long x=0; x<=n; x=x+10
	{	
		//long timer=0;
		for(long i=0; i<currentSize; i++)
		{
			SortArray[i]=
		}
	}
	*/
	
	
	// creates a 2d array that holds size 10 elements per column
	// that 2d array will be filled with the values from the input
	// this allows so that only 1 processor may go at a time to fill up their arrays
	
	
	
	long SortArray[currentSize][columns]= {0,0};
	
	for(long i=0; i<processor; i++)
	{
		if(my_rank==i)
		{
			long counter=(columns)*i;
			for(long y=0; y<=(columns); y++)
			{
				for(long x=0; x<10; x++)
				{
					SortArray[x][y]=Array[counter];
					counter++;
				}
			}
		}
		
	}
	
	
	//now to sort the 2d arrays by their respective columns
	// by reading 10 at a time and then sorting and then
	// placing the sorted back into the 2d array
	
	long tempArray[currentSize]= {0};
	
	for(long y=0; y<=(columns); y++)
		{
			for(long x=0; x<10; x++)
			{
				tempArray[x]=SortArray[x][y];
				
			}
			sort(tempArray, tempArray+currentSize);
			for(long z=0; z<10; z++)
			{
				SortArray[z][y]=tempArray[z];
			}
		}
	
	
	// sends out in groups of 10 to process
	
	
	
	/*
	for(long i=0; i<n; i++)
	{
		cout<<Array[i]<< endl;
	}
	*/
	
	//mergesort(1,//size of the split arrays based on processors);
	
	/* in the ranking system have empty arrays for A and B so that when comparing
		them for the odds and evens all you would have to do is reduce them into
		one array and then be done with that. the hard part comes in when you then
		sort the array.
	*/ 
	
}



/*
void mergesort(long low, long high)
{
	//finds the middle value
	long mid;
	// recursively call and merge 
	if(low < high)
		{
			mid=(low+high)/2;
			mergesort(low, mid);
			mergesort(mid+1, high);
			merge(low, mid, high);
		}
}

void merge(long low, long mid, long high)
{
	long lo, mi, hi, upp;
	lo=low;
	mi=mid;
	hi=high;
	upp=mid+1;
	
	while((lo<=mid)&&(upp<=high))
	{
		if(
	}


}
*/



   

