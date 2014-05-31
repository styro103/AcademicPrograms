import java.io.*;
import java.util.*;

public class Recursion
{
	public static void printbackwards(int n)
	{
		if(n<10)
			System.out.print(n);
		else //Recursive Case
		{
			System.out.print(n%10);
			printbackwards(n/10);
		}
	}
	
	public static int factorial(int n)
	{
		System.out.println("n="+n);
		int answer;
		if(n==0) answer = 1;
		else answer = n*factorial(n-1); //recursive
		System.out.println("Answer="+answer);
		return answer;
	}
	
	public static int fib(int n)
	{
		if(n<2) return 1;
		return fib(n-1)+fib(n-2);
	}
	
	public static int fib2(int n)
	{
		// dynamic programming version
		int [] F = new int[n+1];
		F[0]=F[1]=1;
		for(int i=2; i<=n; i++)
			F[i]=F[i-1]+F[i-2];
		return F[n];
	}

	public static int power(int x, int c)
	{
		if(x==0) return 0;
		if(c<0) return 1/power(x,-c);
		if(c==0) return 1;
		return x*power(x,c-1);
	}

	public static double power2(double x, int c)
	{
		if(x==0) return 0;
		if(c<0) return 1/power2(x,-c);
		if(c==0) return 1;
	
		double y=power2(x,c/2);
		if(c%2==0) return y*y;
		else return x*y*y;
	}

	public static void main(String [] args)
	{
		int x;
		int c;
		Scanner cin=new Scanner(System.in);
		System.out.println("Enter A Natural Number Lower Than 32");
		x = cin.nextInt();
		System.out.println("Enter an exponent.");
		c = cin.nextInt();
		if (x<0)
		{
			System.out.println("Natural Numbers are the Integers After Zero (1;2;3;etc.)");
			x = cin.nextInt();
		}
		printbackwards(x);
		System.out.println("");
		System.out.println(x+"!");
		System.out.println(factorial(x));
		System.out.print(x+"^"+c+" = ");
		System.out.println(power(x,c));
		System.out.print(x+"^"+c+" = ");
		System.out.println(power2(x,c));
		System.out.print("Fib - "+x+" = ");
		System.out.println(fib(x));
		System.out.print("Fib - "+x+" = ");
		System.out.println(fib2(x));
		
		if (x>31)
			System.out.println("n>31: Answer Is Not Correct");
	}
}