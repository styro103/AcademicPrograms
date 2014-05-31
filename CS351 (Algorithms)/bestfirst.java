/*Shaun Mbateng
 12 - 12 - 11
  0-1 Knapsack with Best-First Branch and Bound
 */
package algorithms;

import java.io.*;
import java.util.*;

class bestfirst
{
	public static int n;
	public static int Cap;
	public static int []p;
	public static int []w;
	public static items [] items;
	public static int maxprofit=0;
	public static int totweight = 0;

	public static class node implements Comparable
	{
			int level;
			int profit;
			int weight;
			double bound;

		    public int compareTo(Object o1)
		    {
		    	node x = (node)o1;

		        if ((x.bound)<(this.bound))
		               return -1;
		        if ((this.bound)<(x.bound))
		               return 1;

		        return 0;
		    }
	}

	public static double bound(node s)
	{
		int j, k;
		int totweight;
		double result;

		if (s.weight >= Cap)
			return 0;
		else
		{
			result = s.profit;
			j = s.level +1;
			totweight = s.weight;

			while(j < n && totweight + items[j].getWeight() <= Cap)
			{
				totweight = totweight + items[j].getWeight();
				result = result + items[j].getProfit();
				j++;
			}

			k = j;

			if(k < n)
				result = result +(Cap-totweight)* ((double)items[k].getProfit())/items[k].getWeight();

			return result;
		}
	}

	public static int knapsack(int n, int [] p, int [] w, int Cap)
	{
		node v = new node();
		PriorityQueue<node> PQ;
		PQ = new PriorityQueue<node>();

		v.level = 0;
		v.profit = 0;
		v.weight = 0;
		v.bound = bound(v);

		PQ.add(v);

		while(PQ.size() != 0)
		{
			v = PQ.poll();

			if(v.bound > maxprofit)
			{
				node u = new node();

				u.level = v.level + 1;
				u.weight = v.weight + items[u.level].getWeight();
				u.profit = v.profit + items[u.level].getProfit();

				if(u.weight <= Cap && u.profit > maxprofit)
					maxprofit = u.profit;

				u.bound = bound(u);

				if(u.bound > maxprofit)
					PQ.add(u);


				node t = new node();
				t.level = v.level+1;
				t.weight = v.weight;
				t.profit = v.profit;
				t.bound = bound(t);
				if(t.bound > maxprofit)
					PQ.add(t);
			}
		}
			return maxprofit;
	}

	public static void main(String [] args) throws FileNotFoundException
	{
		Scanner file = new Scanner(new FileReader("itemsL.txt"));
		n = file.nextInt();
		n++;
		Cap = file.nextInt();
		items = new items[n];

		for(int i=1; i<n; i++)
			items[i] = new items(file);


		System.out.println("Max profit: " +knapsack( n, p, w, Cap));
	}
}