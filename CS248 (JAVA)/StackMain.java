import java.io.*;
import java.util.*;

class StackMain
{

  public static void main(String [] args) throws IOException
  {
  
	System.out.println("Number of fish = "+Fish.count);
	
	Scanner fishfile = new Scanner(new FileReader("FishFile.txt"));
	int numfish = fishfile.nextInt();
	//Stack S = new StackArray(100);
	Stack S = new StackLL();
	for(int i=0; i<numfish; i++)
	  S.push(new Fish(fishfile));
	  
	while(!S.isEmpty())
	  System.out.println(S.pop());
  }
}