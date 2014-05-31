/**
Chris Johnson & Shaun Mbateng
The Dating Game
CLASSPATH=$CLASSPATH:.
*/

import java.io.*;
import java.util.*;
import java.util.GregorianCalendar;
import java.util.Calendar;

public class Year3000
{
  public static void main(String [] args) throws IOException
  {
	System.out.println("");
	System.out.println("The Dating Game Program");
	System.out.println("By Shaun Mbateng and Chris Johnson");
	System.out.println("");
    DateInterface d = new MyDate();
    d.set(1,29,2006,0);  // sets the date to Sunday, January 29th, 2006
    while(d.getYear()<3000)
    {
      d.tomorrow();
    }
    // at this point, d represents January 1, 3000
    System.out.println(d);
	
	DateInterface c = new MyDate();
	c.today();
	System.out.println(c);
	// at this point, c is Today's Date and Gets Printed Along With its Weekday
	
	DateInterface a = new MyDate();
	a.set(1,29,2006,0); // sets the date to Sunday, January 29th, 2006
	while(a.getYear()>1799)
	{
		a.yesterday();
	}
	// at this point, d represents December 31, 1799
	a.tomorrow();
	// at this point, d represents January 1, 1800
	System.out.println(a);
  }
}

