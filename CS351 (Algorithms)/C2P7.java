import java.io.*;
import java.util.*;

class C2P7
{
	static void intro() 
	{
		
		System.out.println("");
		System.out.println("**CS 351 Chapter 2 Problem 7**");
		System.out.println("Divide and Conquer");
		System.out.println("");
	}
	
	public static void main(String [] args)
	{
		intro();
		Scanner cin=new Scanner(System.in);
		System.out.println("Number of Elements in List");
		int n;
		n = cin.nextInt();
		
		System.out.println("Type List");
		int [] A;  // declares an array of integers
		A = new int[n]; // allocates the array
		
		// fill it
		for(int i=0; i<n; i++)
		  A[i]=cin.nextInt();
		
		//Find Max
		int max=-500;
		System.out.println("");
		System.out.println("Finding Largest...");
		for(int i=0; i<n; i++)
		{
			if (max<A[i])
			{
				max=A[i];
				System.out.println(max);
			}
		}
		System.out.println("Largest Item");
		System.out.println(max);
	}
}