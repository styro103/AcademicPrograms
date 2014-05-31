import java.io.*;
import java.util.*;
import java.lang.Object.*;
import java.lang.Math;
import java.util.Arrays;

public class Knapsack
{
	static int W;
	static int n;
	static int [] i;
	static int [] pi;
	static int [] wi;
	static int [] bi;
	static int maxprofit;
	static int weight;
	static int profit;
	static int bound;

	static void intro() //Required Function: Displayed Before User Input
	{
		System.out.println("");
		System.out.println("**Knapsack 0/1 Problem**");
		System.out.println("CS 351");
		System.out.println("");
	}

	static void DP()
	{
		for (int a=0; a<n; a++)
			for (wi[a]=0; w[)
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

		DP();
	}
}