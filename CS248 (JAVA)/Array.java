import java.io.*;

class Array
{
	static void changeint( int x )
    {
		x+=3000;
		System.out.println(x);
    }

	static int y;

	static void changey( ) { y+=5000; }

	static void printarray( int [] B )
	{
		for(int i=0; i<5; i++)
			System.out.println(B[i]+" ");
		System.out.println("");
	}
	
	static void changearray( int [] B )
	{
		B[3]+=3000;
	}
  
	public static void main(String [] args)
	{
		int [] A;  // declares an array of integers
		A = new int[5]; // allocates the array

		// fill it
		for(int i=0; i<5; i++)
		  A[i]=i+100;

		// print it
		for(int i=0; i<5; i++)
		  System.out.print(A[i]+" ");
		System.out.println("");

		printarray(A);
		changearray(A);
		printarray(A);

		y=2;
		System.out.println(y);
		changeint(y);
		System.out.println(y);
		changey();
		System.out.println(y);
	}
}