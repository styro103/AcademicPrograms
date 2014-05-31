import java.util.*;

/**
  @author Jon Sorenson
*/

public class Fish implements Comparable
{
  String name;
  String species;
  String color;
  int fins;
  
  public int compareTo(Object x)
  {
    if(! (x instanceof Fish) ) return 0;
	
	Fish y=(Fish) x; // convert x to a Fish object
	// compares # of fins
	if( fins < y.fins ) return -1;
	if( fins == y.fins ) return 0;
	return 1;
	
	// or return fins-y.fins;
	
	// compares names
	/*
	return name.compareTo(y.name); */
  }
  
  public static int count=0;
  
  /** Simple constructor */
  public Fish() // simple constructor
  {
    name=species=color=""; fins=0;
	count++;
  }
  /** Constructor
  @param n name of the fish
  @param s species of the fish
  @param c color of the fish
  @param f the number of fins
  */
  public Fish(String n, String s, String c, int f)
  {
    name=n; species=s; color=c; fins=f;
	count++;
  }
  /** Constructor
  @param s Scanner object to read from to initialize the fish
  */
  public Fish(Scanner s) // throws IOException
  {
    name=s.next();
	species=s.next();
	color=s.next();
	fins=s.nextInt();
	count++;
  }
  // Accessors/Observers
  /** @return the name of the fish */
  public String getName() { return name; } // returns the name
  /** @return the species of the fish */
  public String getSpecies() { return species; } // returns the species
  /** @return the color of the fish */
  public String getColor() { return color; } // returns the color
  /** @return the fin count of the fish */
  public int getFins() { return fins; } // returns the fin count
  
  /** @return string description of the fish for printing */
  public String toString()
  {
    return "Fish name="+name+" species="+species+
	  " color="+color+" # of fins ="+fins;
  }
  
  /** removes one fin, if present */
  public void sharkAttack() // transformer
  {
    if(fins>0) fins--;
  }
}