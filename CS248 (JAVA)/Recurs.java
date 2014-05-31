import java.io.*;

public class Recurs
{
  public static void printbackwards(int n)
  {
    if(n<10) 
	  System.out.print(n);
	else // recursive case
	{
	  System.out.print(n%10);
	  printbackwards(n/10);
	}
  }
  
  public static int factorial(int n)
  {
    System.out.println("n="+n);
	int answer;
    if(n==0) answer=1;
	else answer=n*factorial(n-1);
	System.out.println("answer="+answer);
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

  public static double power(double x, int n)
  {
    if(x==0) return 0;
    if(n<0) return 1/power(x,-n);
    if(n==0) return 1;
	return x*power(x,n-1);
  }
  
  public static double power2(double x, int n)
  {
    if(x==0) return 0;
    if(n<0) return 1/power2(x,-n);
    if(n==0) return 1;
	
	double y=power2(x,n/2);
	if(n%2==0) return y*y;
	else return x*y*y;
  }
  
  public static void main(String [] args)
  {
    //printbackwards(352011);
	System.out.println("");
	//System.out.println(factorial(4));
	System.out.println(power(2,10));
	System.out.println(power(2,-3));
	System.out.println(power2(2,10));
	System.out.println(power2(2,-3));
	System.out.println(power2(1.01,200000));
	//System.out.println(power(1.01,200000));
	System.out.println(fib(3));
	System.out.println(fib(5));
	System.out.println(fib(100));
  }
}