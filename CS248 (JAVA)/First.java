import java.io.*;

/*
If you have classpath problems when trying to run this, use

  CLASSPATH=$CLASSPATH:.

at the command line to fix it.
*/

class First // name must match file name (First.java)
{
  public static void main(String [] args)
  {
    System.out.println("Hi Class!");

    // Loop
    for(int i=99; i>0; i--)
    {
      if(i>1)
        System.out.println(i+" bottles of beer on the wall.");
      else
        System.out.println(i+" bottle of beer on the wall.");
    }
  }
}

