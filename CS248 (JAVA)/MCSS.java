import java.io.*;
import java.util.*;

class MCSS
{

  static int [] A;
  
  static final int range=100;
  static int [] fillrand(int n)
  {
    int [] B = new int[n];
	for(int i=0; i<n; i++)
	  B[i]=(int)((2*range+1)*Math.random())-range;
	return B;
  }
  
  static void print()
  {
    for(int i=0; i<A.length; i++)
	   System.out.print(A[i]+" ");
	System.out.println("");
  }
  
  static void mprint()
  {
    for(int i=mstart; i<=mstop; i++)
	   System.out.print(A[i]+" ");
	System.out.println("");
  }
  
  public static void main(String [] args)
  {
    Scanner kbd=new Scanner(System.in);
	int n = kbd.nextInt();
	A = fillrand(n);
	
	//print();
	
	int ans3 = mcss3();
	System.out.println(ans3);
	int ans2 = mcss2();
	System.out.println(ans2);
	int ans1 = mcss1();
	System.out.println(ans1);
	mprint();
  }
  
  static int mstart=0, mstop=0;
  
  static int mcss1() // this is O(n^3)
  {
    int max=0;
	for(int start=0; start<A.length; start++)
	{
	  for(int stop=start; stop<A.length; stop++)
	  {
	    int sum=0;
		for(int i=start; i<=stop; i++)
		  sum+=A[i];
		if(sum>max) { max=sum; mstart=start; mstop=stop; }
	  }
	}
	return max;
  }
  
  static int mcss2() // this is O(n^2)
  {
    int max=0;
	for(int start=0; start<A.length; start++)
	{
	  int sum=0;
	  for(int stop=start; stop<A.length; stop++)
	  {	
		sum+=A[stop];
		if(sum>max) { max=sum; mstart=start; mstop=stop; }
	  }
	}
	return max;
  }
  
  static int mcss3() // this is O(n)
  {
    int max=0;
	
	int [] prefixsum = new int[A.length];
	prefixsum[0]=A[0];
	for(int i=1; i<A.length; i++)
	  prefixsum[i]=A[i]+prefixsum[i-1];
	  
	int [] sttl = new int[A.length];
	sttl[0]=0;
	for(int i=1; i<A.length; i++)
	{
	  if(sttl[i-1]<prefixsum[i-1])
	    sttl[i]=sttl[i-1];
	  else
	    sttl[i]=prefixsum[i-1];
	}
	
	for(int i=0; i<A.length; i++)
	{
	  int thismax=prefixsum[i]-sttl[i];
	  if(thismax>max) max=thismax;
	}
	
	return max;
  }
}