package algorithms;
/*Shaun Mbateng
 12 - 13 - 11
0-1 Knapsack with Dynamic Programming
*/

import java.io.*;

class dynamic
{
	public static int n=5;
	public static int Cap=9;
	public static int w;

	public static void main(String [] args) throws FileNotFoundException
	{
		int [] b = {0,20,30,35,12,3}; //Had to Change List per Item set
		int [] w = {0,2,5,7,3,1};

		System.out.println("Max Profit: " +findProfit(b, w, n));
	}

	public static int findProfit(int [] b, int w[], int n)
	{
		int [][] p = new int [n+1][Cap+1];

		for(int j = 0; j <= n; j++)
			p[j][0] = 0;

		for(int k = 0; k <= Cap; k++)
			p[0][k] = 0;

		for(int j = 1; j <= n; j++)
			for(int k = 1; k <= Cap; k++)
			{
				if(w[j] <= k)
					p[j][k] = Math.max(p[j-1][k-w[j]] + b[j], p[j-1][k]);
				else
					p[j][k] = p[j-1][k];
			}

		return p[n][Cap];
	}
}