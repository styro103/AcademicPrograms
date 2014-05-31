import java.io.*;
import java.util.*;
import java.lang.Object.*;
import java.lang.Math;

class C3P3
{
	static int n,k,s,m,bc1,bc2;

	static void intro() //Required Function: Displayed Before User Input
	{
		System.out.println("");
		System.out.println("**Binomial Coefficient**");
		System.out.println("Algorithms 3.1 and 3.2");
		System.out.println("");
	}

	public static void main(String [] args) throws IOException
	{
		intro();
		Scanner cin=new Scanner(System.in);
		System.out.println("What is the value of n?");
		n = cin.nextInt();
		s = n;
		System.out.println("");
		System.out.println("What is the value of k?");
		k = cin.nextInt();
		m = k;
		System.out.println("");
		while (n<k)
		{
			System.out.println("n has to be greater than k.");
			System.out.println("");
			System.out.println("What is the value of n?");
			n = cin.nextInt();
			System.out.println("What is the value of k?");
			k = cin.nextInt();
		}
		bc1 = Alg1(n,k);
		bc2 = Alg2(s,m);
		System.out.println("The binomial coefficient using Algorithm 3.1 is "+bc1);
		System.out.println("The binomial coefficient using Algorithm 3.2 is "+bc2);
		if (bc1==bc2)
		{
			System.out.println("The coefficients are the same, as they should be.");
		}
	}

	static int Alg1(int n,int k)
	{
		if (k==0 || n==k)
			return 1;
		else
			return Alg1(n-1, k-1) + Alg1(n-1, k);
	}

	static int Alg2(int s, int m)
	{
		int [][] B;
		B = new int[s+1][m+1];
		for (int i=0; i<=s; i++)
		{
			for (int j = 0; j<=Math.min(i,m); j++)
			{
				if (j==0 || j==i)
					B[i][j] = 1;
				else
						B[i][j] = B[i-1][j-1] + B[i-1][j];
			}
		}
		return B[s][m];
	}
}