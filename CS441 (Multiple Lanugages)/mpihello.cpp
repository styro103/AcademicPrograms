#include <iostream>
#include "mpi.h"
/*
thomas:$ module load openmpi-x86_64
thomas:$ mpicxx mpihello.cpp
thomas:$ mpirun -np 10 a.out
*/

using namespace std;

int main(int argc, char *argv[])
{
  // start up MPI
  MPI_Init(&argc,&argv);
  
  // get number of processors
  int np;
  MPI_Comm_size(MPI_COMM_WORLD, &np);
  // get my ID number
  int id;
  MPI_Comm_rank(MPI_COMM_WORLD, &id);
  
  cout << "I am "<<id<<endl;
  
  cout << "Hello world!\n";
  
  // done!
  MPI_Finalize();
  return 0;
}
