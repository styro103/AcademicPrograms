import java.io.*;
import java.util.*;

public class ivee implements CPI, Comparable
{
	
	String name;
	String sex;
	int age;
	
	public ivee()
	{
		sex=name=""; age=0;	
	}
	
	public ivee( String n, int a, String s)
	{
		 name=n; age=a; sex=s;
	}

	public ivee(Scanner cin)
	{
		
		name=cin.next();
		age=cin.nextInt();
		sex=cin.next();
	}
	
		public ivee(Scanner cin, int x)
	{
		
		name=cin.next();
		age=0;
		sex="";
	}
	
	public String toString()
	{
	return  name + " " + age + " "  + sex;
	}
	
	
	 public int compareTo(Object x)
  {
    if(! (x instanceof ivee) ) return 0;
	ivee y=(ivee) x;	
	return name.compareTo(y.name); 
  }
  
	
	public String getName()	{return name;}
	public int getAge() {return age;}
	public String getSex() {return sex;}
}