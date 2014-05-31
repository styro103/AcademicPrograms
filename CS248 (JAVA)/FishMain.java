import java.io.*;
import java.util.*;

class FishMain
{


  public static double avgfins(Fish [] A)
  {
    double total=0;
	for(int i=0; i<A.length; i++)
	  total += A[i].getFins();
	if(A.length==0) return 0;
	return total/A.length;
  }
  
  public static void randomsharkattack(Fish [] A)
  {
    int whichfish = (int)(A.length*Math.random());
	A[whichfish].sharkAttack();
  }

  public static void main(String [] args) throws IOException
  {
  /*
    Fish x,y;
	
	x = new Fish("Angela","angelfish","blue",5);
	
	System.out.println(x);
	System.out.println(x.getName());
	x.sharkAttack();
	System.out.println(x);
	
	y = new Fish("Nemo","clownfish","orange",7);
	System.out.println(y);
	//y.sharkAttack();
	System.out.println(y.getFins());
	
	while(y.getFins()>0)
    {
      y.sharkAttack();
	  System.out.println("Shark Attack!!!! Oh no!");
	}
	System.out.println(y);
	*/
	
	System.out.println("Number of fish = "+Fish.count);
	
	Scanner fishfile = new Scanner(new FileReader("fishfile.txt"));
	int numfish = fishfile.nextInt();
	Fish [] school = new Fish[numfish]; // array of Fish
	for(int i=0; i<school.length; i++)
	  school[i]=new Fish(fishfile);
	for(int i=0; i<school.length; i++)
	  System.out.println(school[i]);
	//System.out.println(Arrays.toString(school));
	
	System.out.println("Number of fish = "+school[0].count);
	System.out.println("Number of fish = "+Fish.count);
	
	System.out.println("The avg. # of fins is "+avgfins(school));
	System.out.println("Oh no, 10 sharks!");
	for(int shark=0; shark<10; shark++)
	  randomsharkattack(school);
	System.out.println("The avg. # of fins is "+avgfins(school));
	for(int i=0; i<school.length; i++)
	  System.out.println(school[i]);
	  
	System.out.println("The largest fish is "+ util.max(school));
  }
}