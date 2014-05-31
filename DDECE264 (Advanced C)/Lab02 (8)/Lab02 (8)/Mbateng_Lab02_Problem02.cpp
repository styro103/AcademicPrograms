/*ECE 264
  Lab 02
  Problem 02
  Shaun Mbateng
  This program inputs two Matricies, Does Some Matrix Arithmetic,
	and Displays the Result
*/

#include <stdio.h>
#include <iostream>
using namespace std;

void printMatrix(int [][10], int dimension); //Function to Print Matrix
void matrixAddition(int result[][10], int a[][10], int b[][10], int dimension); //Function to Add Matricies
void matrixSubtraction(int result[][10], int a[][10], int b[][10], int dimension); //Function to Subtract Matricies
void matrixMultiplication(int result[][10], int a[][10], int b[][10], int dimension); //Function to Multiply Matricies
void matrixTranspose(int result[][10], int a[][10], int dimension); //Function to Transpose Matrix

int main()
{
	//10x10 Matricies
	int A[10][10];
	int B[10][10];
	int  Result[10][10];

	cout<<endl;

	//Fill Matrix A
	for (int i=0; i<10; i++)
	{
		for (int j=0; j<10; j++)
		{
			cout<<"Enter element ["<<i+1<<","<<j+1<<"] of A"<<endl;
			cin>>A[i][j];
		}
			
	}
	
	//Fill Matrix B
	for (int i=0; i<10; i++)
	{
		for (int j=0; j<10; j++)
		{
			cout<<"Enter element ["<<i+1<<","<<j+1<<"] of B"<<endl;
			cin>>B[i][j];
		}
			
	}

	cout<<endl;
	cout<<"Matrix A:"<<endl;
	
	printMatrix(A, 10); //Print Matrix A

	cout<<endl;
	cout<<"Matrix B:"<<endl;

	printMatrix(B, 10); //Print Matrix B

	cout<<endl;
	cout<<"A+B Result:"<<endl;

	matrixAddition(Result, A, B, 10); //Add Matrix A & B

	cout<<endl;
	cout<<"A-B Result:"<<endl;

	matrixSubtraction(Result, A, B, 10); //Subtract B From A

	cout<<endl;
	cout<<"B-A Result:"<<endl;

	matrixSubtraction(Result, B, A, 10); //Subtract A From B
	
	cout<<endl;
	cout<<"A*B Result:"<<endl;

	matrixMultiplication(Result, A, B, 10); //Perform A*B
	
	cout<<endl;
	cout<<"B*A Result:"<<endl;

	matrixMultiplication(Result, B, A, 10); //Perform B*A
	
	cout<<endl;
	cout<<"A Transposed Result:"<<endl;
	
	matrixTranspose(Result, A, 10); //Trnaspose A
	
	cout<<endl;
	cout<<"B Transposed Result:"<<endl;
	
	matrixTranspose(Result, B, 10); //Transpose B
	
	return 0;
}

void printMatrix(int M[][10], int dimension) //Print Matrix
{	
	for (int i=0; i<10; i++) //From 0 to Row Length
	{
		for (int j=0; j<10; j++) //From 0 to Column Length
		{
			cout<<M[i][j]<<" "; //Print Element
			if (j==9) //If End of Row, End Line
				cout<<endl;
		}	
	}
}

void matrixAddition(int result[][10], int a[][10], int b[][10], int dimension) //Add Matrix
{
	for (int i=0; i<10; i++) //From 0 to Row Length
	{
		for (int j=0; j<10; j++) //From 0 to Column Length
		{
			result[i][j] = a[i][j] + b[i][j]; //Add Elements, Store in Result
		}	
	}

	printMatrix(result, 10); //Print Matrix
}

void matrixSubtraction(int result[][10], int a[][10], int b[][10], int dimension) //Subtract Matrix
{
	for (int i=0; i<10; i++) //From 0 to Row Length
	{
		for (int j=0; j<10; j++) //From 0 to Column Length
		{
			result[i][j] = a[i][j] - b[i][j]; //Subtract Elements, Store in Result
		}	
	}

	printMatrix(result, 10); //Print Matrix
}

void matrixMultiplication(int result[][10], int a[][10], int b[][10], int dimension) //Multiply Matrix
{
	for (int i=0; i<10; i++) //From 0 to Row Length
	{
		for (int j=0; j<10; j++) //From 0 to Column Length
		{
			//Perform Multiplication, Store in Result
			result[i][j] = 0;

			for (int k=0; k<10; k++)
			{
				result[i][j]+= a[i][k]*b[k][j];
			}
		}	
	}

	printMatrix(result, 10); //Print Matrix
}

void matrixTranspose(int result[][10], int a[][10], int dimension) //Transpose Matrix
{
	for (int i=0; i<10; i++) //From 0 to Row Length
	{
		for (int j=0; j<10; j++)  //From 0 to Column Length
		{
			result[i][j] = a[9-i][9-j]; //Transpose Matrix, Store in Result
		}
	}
	
	printMatrix(result, 10); //Print Matrix	
}
