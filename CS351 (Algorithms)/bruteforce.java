/*Shaun Mbateng
 *12 - 13 - 11
  0-1 Knapsack with Brute Force
 */
package algorithms;

class bruteforce
{
	private static final int Cap = 9;

	public static void main(String [] args)
	{
		int [] p = {20,30,35,12,3}; //Had to Change List per Item set
		int [] w = {2,5,7,3,1};

		System.out.println("Max Profit: " + forceful(p,w));
	}

	public static int forceful(int [] p, int [] w)
	{
		int maxprofit = 0, i = 0;

		int [] benefit = new int[(int) Math.pow(2, 5)];
		int [] weight = new int[(int) Math.pow(2, 5)];

		for(int a = 0; a <= 1; a++)
			for(int b = 0; b <= 1; b++)
				for(int c = 0; c <= 1; c++)
					for(int d = 0; d <= 1; d++)
						for(int e = 0; e <= 1; e++)
						{
							if(a==1)
							{
								benefit[i] += p[0];
								weight[i] += w[0];
							}
							if(b==1)
							{
								benefit[i] += p[1];
								weight[i] += w[1];
							}
							if(c==1)
							{
								benefit[i] += p[2];
								weight[i] += w[2];
							}
							if(d==1)
							{
								benefit[i] += p[3];
								weight[i] += w[3];
							}
							if(e==1)
							{
								benefit[i] += p[4];
								weight[i] += w[4];
							}
							i++;
						}

		for(int j = 0; j < benefit.length; j++)
			if(maxprofit < benefit[j] && weight[j] <= Cap)
				maxprofit = benefit[j];

		return maxprofit;
	}
}