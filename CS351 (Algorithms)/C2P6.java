import java.io.*;
import java.util.*;

class C2P6
{
	static void intro() //
	{
		// This Program Doesn't Work
		System.out.println("");
		System.out.println("**CS 351 Chapter 2 Problem 6**");
		System.out.println("Trinary Search");
		System.out.println("");
	}
	
	public static void main(String [] args)
	{
		Scanner cin=new Scanner(System.in);
		System.out.println("Number of Elements in List");
		int n;
		n = cin.nextInt();
		
		System.out.println("Type Sorted List");
		int [] A;  // declares an array of integers
		A = new int[n]; // allocates the array
		int [] B;
		B = new int[n/3];

		// fill it
		for(int i=0; i<n; i++)
		  A[i]=cin.nextInt();

		// print it
		for(int i=0; i<n; i++)
		  System.out.print(A[i]+" ");
		System.out.println("");
		
		//Find element
		System.out.println("What element woult you like to find?");
		int f;
		f = cin.nextInt();
		if (f < A[0] || f > A[n]);
			System.out.println("Element is not in list");
		else
		{
			for(int d=0; d<n; d++)
			{
				if (f>A[0] && f<A[n/3]);
				{
					for(int c=0; c<n/3; c++)
						B[c]=A[d];
						
				}
				else if (f>A[n/3] && f<A[2n/3]);
				{
					for(int c=n/3; c<2n/3; c++)
						B[c]=A[d];
				}
				else if (f>A[n/3] && f<A[n]);
				{
					for(int c=2n/3; c<n; c++)
						B[c]=A[d];
				}
			}
			
			System.out.println(B[c]);
		}
	}
}