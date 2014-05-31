import java.io.*;

class FoodMain
{
  public static void main(String [] args)
  {
    Food f=new Food(5.5,100);
	System.out.println(f);
	
	cheeseburger c = new cheeseburger(3,true," ketchup, mustard, onions");
	System.out.println(c);
	
	Food g;
	g=c; // oooh!
	System.out.println(g);
	// cheeseburger c2 = f; is illegal!!
	g.stale();
	c.stale();
	System.out.println(g);
  }
}