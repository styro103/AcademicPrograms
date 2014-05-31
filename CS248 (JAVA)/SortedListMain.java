import java.io.*;
import java.util.*;

class SortedListMain
{


 
  
 
  public static void main(String [] args) throws IOException
  {
 
	
	System.out.println("Number of fish = "+Fish.count);
	
	Scanner fishfile = new Scanner(new FileReader("fishfile.txt"));
	int numfish = fishfile.nextInt();
	SortedList L=new SortedListLL(); // array of Fish
	for(int i=0; i<numfish; i++)
	  L.insert(new Fish(fishfile));
	for(int i=0; i<L.size(); i++)
	  System.out.println(L.get(i));
	  
	System.out.println(((Fish)L.get(0)).getName());
	

	
  }
}