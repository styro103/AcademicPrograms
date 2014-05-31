import java.io.*;
import java.util.*;
import java.lang.Object.*;
import java.lang.Math;
import java.util.Arrays;

public class KnapsackBF
{
	static int W;
	static int n;
	static int [] i;
	static int [] pi;
	static int [] wi;
	static int [] bi;
	static int [] A;
	static int maxprofit;
	static int profit;
	static int weight;
	static int maxweight;
	static int bound;

	static void intro() //Required Function: Displayed Before User Input
	{
		System.out.println("");
		System.out.println("**Knapsack 0/1 Problem**");
		System.out.println("CS 351");
		System.out.println("");
	}

	public static void main(String [] args) throws IOException
	{
		intro();
		Scanner cin=new Scanner(System.in);
		System.out.println("What is the maximum weight of the sack?");
		W = cin.nextInt();
		System.out.println("How many items are there?");
		n = cin.nextInt();
		i = new int[n];
		pi = new int[n];
		wi = new int[n];
		bi = new int[n];
		A = new int[n];

		for (int s=0; s<n; s++)
		{
			i[s] = s+1;
		}

		System.out.println("");
		System.out.println("The items must be entered sorted in nonincreasing order of the benefit (p/w).");
		System.out.println("");

		for (int s=1; s<=n; s++)
		{
			System.out.println("What is the profit of item "+s);
			pi[s-1] = cin.nextInt();
		}

		for (int s=1; s<=n; s++)
		{
			System.out.println("What is the weight of item "+s);
			wi[s-1] = cin.nextInt();
		}

		for (int s=1; s<=n; s++)
		{
			bi[s-1] = pi[s-1]/wi[s-1];
		}

		for (int s=1; s<=Math.pow(2,n); s++)
		{
			int j=n;
			weight=0;
			profit=0;
			while (A[j-1]!=0 && j>1)
			{
				A[j-1]=0;
				j--;
			}
			A[j-1]=1;
			for (int k=1; k<=n; k++)
			{
				if (A[k-1]==1)
				{
					weight=weight+wi[k-1];
					profit=profit+pi[k-1];
				}
			}
			if ((profit>maxprofit) && (weight<=W))
			{
				maxprofit=profit;
				maxweight=weight;
			}
		}
		for (int t=0; t<n; t++)
		{
			System.out.print(A[t]);
		}
	}
}