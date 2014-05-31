
public class util
{
  public static Comparable max( Comparable [] A)
  {
    Comparable max = A[0];
	for(int i=1; i<A.length; i++)
	//if(max < A[i]) max=A[i];
	  if(max.compareTo(A[i])<0) max=A[i];
	return max;
  }
  
}