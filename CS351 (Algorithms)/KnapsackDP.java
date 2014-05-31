/*
 Shaun Mbateng
 CS 351: Chen
 Knapsack 0/1 Problem: Dynammic Programming Method
 */

import java.util.*;
import java.io.*;
import java.lang.*;

public class KnapsackDP
{
	static int n=5, W;
	static obj st[];
	public static BufferedReader br =new BufferedReader(new InputStreamReader(System.in));

	static class obj
	{
		int weight;
		int profit;
	}

	static void intro()
	{
		System.out.println("");
		System.out.println("**Knapsack 0/1 Problem**");
		System.out.println("Dynammic Programming Method");
		System.out.println("CS 351");
		System.out.println("");
	}

	public static void main(String args[]) throws IOException
	{
		intro();
		int i=0;
		System.out.println("Enter total number of objects");
		n = Integer.parseInt(br.readLine());
		System.out.print("Enter the maximum weight sack can take: ");
		W = Integer.parseInt(br.readLine());
		st = new obj[n+1];

		st[0] = new obj();
		st[0].weight = st[0].profit = 0;

		for(i=1; i<=n; i++)
		{
			st[i] = new obj();
			System.out.println("For Object "+(i)+":");
			System.out.print("\tWeight: ");
			st[i].weight = Integer.parseInt(br.readLine());
			System.out.print("Profit: ");
			st[i].profit = Integer.parseInt(br.readLine());
			System.out.println("");
		}

		System.out.print("Optimal Solution is Set: {");

		simple_fill();
	}

	static void simple_fill()
	{
		int [][]s = new int[n+1][W+1];
		for (int w = 0; w<= W; w++)
			s[0][w] = 0;
		for(int i=0; i<=n; i++)
			s[i][0]=0;
		for(int i=1; i<=n; i++)
			for (int w = 0; w<= W; w++)
				if (st[i].weight <= w)
				{
					if (st[i].profit + s[i-1][w-st[i].weight] > s[i-1][w])
						s[i][w] = st[i].profit + s[i-1][w- st[i].weight];
					else
						s[i][w] = s[i-1][w];
				}
				else
					s[i][w] = s[i-1][w];
		int i = n;
		int k = W;
		int prof = 0;
		while((i>0)&&(k>0))
		{
			if (s[i][k] != s[i-1][k])
			{
				System.out.print(i);
				k = k - st[i].weight;
				prof += st[i].profit;
			}
			i--;
		}
		System.out.print("}");
		System.out.println("");
		System.out.println("It will yield a profit of $"+prof+".");
	}
}