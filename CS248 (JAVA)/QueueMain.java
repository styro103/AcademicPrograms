import java.io.*;
import java.util.*;

class QueueMain
{

  public static void main(String [] args) throws IOException
  {
  
	System.out.println("Number of fish = "+Fish.count);
	
	Scanner fishfile = new Scanner(new FileReader("FishFile.txt"));
	int numfish = fishfile.nextInt();
	Queue Q = new QueueLL();
	for(int i=0; i<numfish; i++)
	  Q.enqueue(new Fish(fishfile));
	  
	while(!Q.isEmpty())
	  System.out.println(Q.dequeue());
  }
}