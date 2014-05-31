import java.io.*;

class overflow
{
  public static void main(String [] args)
  {
    long x=1;
	while (x>=0)
    { x=2*x+1; System.out.println(x); }
  }
}