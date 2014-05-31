import java.io.*;
import java.util.*;

class Reading
{
	public static void main(String [] args)
	{
	
		// declare the input stream
		
		Scanner cin=new Scanner(System.in);
		
		// read an integer
		
		System.out.println("Please enter an integer: ");
		int x = cin.nextInt();
		
		// add one and print it
		
		x++;
		System.out.println(x);
	}
}