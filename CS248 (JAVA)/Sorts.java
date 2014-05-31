import java.io.*;
import java.util.*;

public class Sorts
{
  private static void swap(Comparable [] A, int x, int y)
  {
    Comparable temp=A[x];
	A[x]=A[y];
	A[y]=temp;
  }

  public static void bubble(Comparable [] A)
  {
    boolean didswap=false;
	do
	{
	  didswap=false;
      for(int i=0; i+1<A.length; i++)
	    //if(A[i]>A[i+1])
	    if(A[i].compareTo(A[i+1])>0)
	      { swap(A,i,i+1); didswap=true; }
    }
	while(didswap);
  }

  private static int findmaxpos(Comparable [] B, int x)
  {
    int max=0;
	for(int i=1; i<=x; i++)
	  if(B[i].compareTo(B[max])>0) max=i;
	return max;
  }

  public static void selection(Comparable [] A)
  {
    for(int last=A.length-1; last>0; last--)
	{
	  int maxloc = findmaxpos(A,last);
	  swap(A,maxloc,last);
	}
  }

  public static void insertion(Comparable [] A)
  {
    for(int i=1; i<A.length; i++)
	{
	  Comparable toinsert=A[i];
	  int j;
	  for(j=i-1; j>=0; j--)
	  {
	    if(A[j].compareTo(toinsert)>0)
		  A[j+1]=A[j];
		else
		{
		  A[j+1]=toinsert;
		  j=-10; // to break out of the loop
		}
	  }
	  if(j==-1) // need to put the item in
	    A[0]=toinsert;
	}
  }

  // functions for shell sort

  private static void insertion(Comparable [] A, int offset, int gap)
  {
    for(int i=offset+gap; i<A.length; i=i+gap)
	{
	  Comparable toinsert=A[i];
	  int j;
	  for(j=i-gap; j>=0; j=j-gap)
	  {
	    if(A[j].compareTo(toinsert)>0)
		  A[j+gap]=A[j];
		else
		{
		  A[j+gap]=toinsert;
		  j=-2*gap; // to break out of the loop
		}
	  }
	  if(j>=-gap) // need to put the item in
	    A[offset]=toinsert;
	}
  }

  public static void shell(Comparable [] A)
  {
    int gap=(int) (A.length/2.2);
	if(gap<1) gap=1;
	while(gap>1)
	{
	  for(int offset=0; offset<gap; offset++)
	    insertion(A,offset,gap);
	  gap=(int) (gap/2.2);
	}
	insertion(A); // for gap==1
  }

  // functions for quicksort

  public static void quicksort(Comparable [] A)
    { quicksort(A,0,A.length-1); }

  private static void quicksort(Comparable [] A,
    int start, int stop)
    {
	  // base cases
	  if(stop<=start) // size 0 or 1
	    return; // already sorted!
	  if(start+1==stop) // then size==2
	  {
	    if(A[start].compareTo(A[stop])>0)
		  swap(A,start,stop);
		return;
	  }
	  // recursive case
	  int pivotloc = partition(A,start,stop);
	  quicksort(A,start,pivotloc-1);
	  quicksort(A,pivotloc+1,stop);
	}

  private static int partition(Comparable [] A,
    int start, int stop)
  {
    Comparable pivot = A[stop];
	int left=start;
	int right=stop-1;
	while(left<right)
	{
	  while(A[left].compareTo(pivot)<0) left++;
	  while(right>start &&
	      A[right].compareTo(pivot)>=0) right--;
      if(left<right) swap(A,left,right);
	}
	swap(A,left,stop);
	return left;
  }

  // Mergesort functions

  public static void mergesort(Comparable [] A)
    { mergesort(A,0,A.length-1); }

  private static void mergesort(Comparable [] A,
    int start, int stop)
    {
	  // base cases
	  if(stop<=start) // size 0 or 1
	    return; // already sorted!
	  if(start+1==stop) // then size==2
	  {
	    if(A[start].compareTo(A[stop])>0)
		  swap(A,start,stop);
		return;
	  }
	  // recursive case
	  int mid=(start+stop)/2;
	  mergesort(A,start,mid);
	  mergesort(A,mid+1,stop);
	  merge(A,start,mid,stop);
	}

  private static void merge(Comparable [] A,
    int start, int mid, int stop)
  {
    Comparable [] B = new Comparable[stop-start+1];
	int x=start, y=mid+1;
	for(int i=0; i<B.length; i++)
	{
	  if(x<=mid && (y>stop || A[x].compareTo(A[y])<=0))
	    B[i]=A[x++];
	  else
	    B[i]=A[y++];
	}
	for(int i=0; i<B.length; i++)
	  A[start+i]=B[i];
  }


  public static void main(String [] args) throws IOException
  {
    Scanner fishfile = new Scanner(new FileReader("fishfile.txt"));
	int numfish = fishfile.nextInt();
	Fish [] school = new Fish[numfish]; // array of Fish
	for(int i=0; i<school.length; i++)
	  school[i]=new Fish(fishfile);

	//mergesort(school);

	//for(int i=0; i<school.length; i++)
	  //System.out.println(school[i]);

	/* */
	Integer [] A = new Integer[1000000];
	for(int i=0; i<A.length; i++)
	  A[i]=new Integer(A.length-i);

	bubble(A);
	for(int i=0; i<A.length; i++)
	  System.out.print(A[i]+" ");
	System.out.println("");
	/* */
  }
}