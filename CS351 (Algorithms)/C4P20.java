import java.io.*;
import java.util.*;
import java.util.Arrays;

public class C4P20
{
	static void intro() //Function: Displayed Before User Input
	{
		System.out.println("");
		System.out.println("**Scheduling Algorithm**");
		System.out.println("Section 4.3.1");
		System.out.println("");
	}

	public static void main(String [] args) throws IOException
	{
		intro();
		Scanner cin=new Scanner(System.in);
		int n;
		int Time = 0;
		int [] T;
		int [] j;
		System.out.println("How many jobs are there?");
		n = cin.nextInt();
		T = new int [n];
		j = new int [n*2];

		for (int t=1; t<=n; t++)
		{
			System.out.println("What is the time for job "+t);
			T[t-1] = cin.nextInt();
			for (int i=0; i<n*2; i++)
			{
				if ((i*3)%2==0)
					j[i] = i+1;
				else
					j[i] = T[t-1];
			}
		}
		Arrays.sort(T);
		System.out.println("");

		for (int i=0;i<n;i++)
		{
			for (int s=i;s>=0;s--)
			{
				Time = Time+T[s];
			}
		}

		System.out.println("The minimum total time is "+Time);
		System.out.println("Do the schedule according to the jobs with these respective times:");

		for (int i=0; i<n; i++)
		{
			if (i==n-1)
			{
				System.out.print(T[i]);
			}
			else
			{
				System.out.print(T[i]+", ");
			}
		}

		System.out.println("");
	}
}