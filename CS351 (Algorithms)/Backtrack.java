/*Shaun Mbateng
 *12 - 12 - 11
  0-1 Knapsack with Back Tracking
 */
package algorithms;

import java.io.*;
import java.util.*;

class backtrack
{
	public static int n;
	public static int Cap;
	public static String [] include;
	public static String [] bestset;
	public static items [] items;
	public static int numbest = 0;
	public static int maxprofit = 0;
	public static int totweight=0;

	public static void main(String [] args) throws FileNotFoundException
	{
		Scanner file = new Scanner(new FileReader("items.txt"));
		n = file.nextInt();
		n++;
		Cap = file.nextInt();
		include = new String[n];
		bestset = new String[n];
		items = new items[n];

		for(int i=1; i<n; i++)
		{
			items[i] = new items(file);
		}

		knapsack(0,0,0);

		int sackWeight=0;

		for(int k=1; k < n; k++)
		{
			if(bestset[k]=="yes")
				sackWeight += items[k].getWeight();

		}

		System.out.println("Amount of items: " +numbest);
		System.out.println("Max profit: " +maxprofit);
		System.out.println("Total weight: " +sackWeight+ "\n");
		System.out.println("Items picked:");

		for(int j = 1; j < n; j++)
			System.out.println("Item " + j +": " + bestset[j]);

	}

	public static void knapsack(int i, int profit, int weight)
	{
		if (weight <= Cap && profit > maxprofit)
		{
			maxprofit = profit;
			numbest = i-1;

			for(int j = 0; j < n; j++)
				bestset[j] = include[j];
		}

		if(promising(i, weight, profit))
		{
			include[i+1] = "yes";
			knapsack(i+1, profit + items[i+1].getProfit(), weight + items[i+1].getWeight());
			include[i+1] = "no";
			knapsack(i+1, profit, weight);
		}
	}

	public static boolean promising(int i, int weight, int profit)
	{
		int j, k;
		float bound;

		if(weight >= Cap)
			return false;
		else
		{
			j = i+1;
			bound = profit;
			totweight = weight;
			while (j < n && totweight + items[j].getWeight() <= Cap)
			{
				totweight = totweight + items[j].getWeight();
				bound = bound + items[j].getProfit();
				j++;
			}
			k = j;
			if (k < n)
				bound = bound + (Cap - totweight) * (items[k].getProfit()/items[k].getWeight());

			return bound > maxprofit;
		}
	}
}