import java.io.*;
import java.util.*;

class C3P8
{
	static void intro() //Required Function: Displayed Before User Input
	{
		System.out.println("");
		System.out.println("**Floyd's Algorithm 2**");
		System.out.println("Algorithm 3.4");
		System.out.println("");
	}

	public static void main(String [] args) throws IOException
	{
		intro();
		Scanner cin=new Scanner(System.in);
		int n;
		int i,j,k;

		System.out.println("How many vertices are there?");
		n = cin.nextInt();

		int [][] W = new int [n+1][n+1];
		int [][] D = new int [n+1][n+1];
		int [][] P = new int [n+1][n+1];

		W[0][0] = 0;
		D[0][0] = 0;
		P[0][0] = 0;

		System.out.println("Type in the Matrix of the Weights (One Row at a time).");
		for (int row=0; row<=n; row++)
		{
			for (int column=0; column<=n; column++)
				W[row][column] = cin.nextInt();
		}

		for (i=1;i<=n; i++)
		{
			for (j=1; j<=n; j++)
				P[i][j] = 0;
		}
		D = W;
		for (k=1; k<=n;k++)
		{
			for (i=1; i<=n; i++)
			{
				for (j=1; j<=n; j++)
				{
					if (D[i][k] + D[k][j] < D[i][j])
					{
						P[i][j] = k;
						D[i][j] = D[i][k] + D[k][j];
					}
				}
			}
		}
		System.out.println("");
		System.out.println("W-Matrix");
		for (int row=0; row<=n; row++)
		{
			for (int column=0; column<=n; column++)
				System.out.print(W[row][column]);
			System.out.println();
		}
		System.out.println("");
		System.out.println("D-Matrix");
		for (int row=0; row<=n; row++)
		{
			for (int column=0; column<=n; column++)
				System.out.print(D[row][column]);
			System.out.println();
		}
		System.out.println("");
		System.out.println("P-Matrix");
		for (int row=0; row<=n; row++)
		{
			for (int column=0; column<=n; column++)
				System.out.print(P[row][column]);
			System.out.println();
		}
	}
}