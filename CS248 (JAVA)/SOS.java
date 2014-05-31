//Shaun Mbateng
//Chris Johnson
//Sorting Out Sorts
// April 8th, 2011
import java.io.*;
import java.util.*;
//CLASSPATH=$CLASSPATH:.

public class SOS
{
	public static void main(String [] args) throws IOException
	{
		int n;
		double start, stop, runningtime;
		Integer [] list; // main array
		Integer [] array; // array used for sorting
		Scanner cin=new Scanner(System.in);
		Scanner kbd = new Scanner(System.in);
		Random generator = new Random();
		String run = "yes";

		do{
			System.out.println("");
			System.out.println("What is the size of the list to be sorted?");
			n = cin.nextInt();
			System.out.println("");
			list = new Integer[n]; //Initializing List to n
			array = new Integer[n]; //Initializing Array to n
			
			for (int i=0;i<list.length;i++) {list[i]= new Integer(generator.nextInt( n ));} //fills the array list with random integers.
			if (n<=100) //Prints List if n<=100
			{
				System.out.println("List Before Sorting:");
				for (int i=0;i<list.length;i++)
				{
					System.out.print(list[i] + " ");
				}
				System.out.println("");
				System.out.println("");
			}


			for(int i=0; i<array.length; i++) //Sets Array = List
				{array[i]=list[i];}

			System.out.println("Will now sort the list using Bubble Sort.");
			start=System.currentTimeMillis();
			Sorts.bubble(array); //bubble sort
			stop=System.currentTimeMillis();
			runningtime=stop-start;
			if (n<=100)
				for(int i=0; i<array.length; i++)
				System.out.print(array[i]+", ");
			System.out.println("the running time is " +runningtime +" milliseconds.");
			for(int i=0; i<array.length; i++)
			{array[i]=list[i];}
			System.out.println("");

			System.out.println("Will now sort the list using Selection Sort.");
			start=System.currentTimeMillis();
			Sorts.selection(array); //selection sort
			stop=System.currentTimeMillis();
			runningtime=stop-start;
			if (n<=100)
				for(int i=0; i<array.length; i++)
				System.out.print(array[i]+", ");
			System.out.println("the running time is " +runningtime +" milliseconds.");
			for(int i=0; i<array.length; i++)
			{array[i]=list[i];}
			System.out.println("");

			System.out.println("Will now sort the list using Insertion Sort.");
			start=System.currentTimeMillis();
			Sorts.insertion(array); //insertion sort
			stop=System.currentTimeMillis();
			runningtime=stop-start;
			if (n<=100)
				for(int i=0; i<array.length; i++)
				System.out.print(array[i]+", ");
			System.out.println("the running time is " +runningtime +" milliseconds.");
			for(int i=0; i<array.length; i++)
			{array[i]=list[i];}
			System.out.println("");

			System.out.println("Will now sort the list using Quick Sort.");
			start=System.currentTimeMillis();
			Sorts.quicksort(array); //quick sort
			stop=System.currentTimeMillis();
			runningtime=stop-start;
			if (n<=100)
				for(int i=0; i<array.length; i++)
				System.out.print(array[i]+", ");
			System.out.println("the running time is " +runningtime +" milliseconds.");
			for(int i=0; i<array.length; i++)
			{array[i]=list[i];}
			System.out.println("");

			System.out.println("Will now sort the list using Shell Sort.");
			start=System.currentTimeMillis();
			Sorts.shell(array); //shell sort
			stop=System.currentTimeMillis();
			runningtime=stop-start;
			if (n<=100)
				for(int i=0; i<array.length; i++)
				System.out.print(array[i]+", ");
			System.out.println("the running time is " +runningtime +" milliseconds.");
			for(int i=0; i<array.length; i++)
			{array[i]=list[i];}
			System.out.println("");

			System.out.println("Will now sort the list using Merge Sort.");
			start=System.currentTimeMillis();
			Sorts.mergesort(array); //merge sort
			stop=System.currentTimeMillis();
			runningtime=stop-start;
			if (n<=100)
				for(int i=0; i<array.length; i++)
				System.out.print(array[i]+", ");
			System.out.println("the running time is " +runningtime +" milliseconds.");
			for(int i=0; i<array.length; i++)
			{array[i]=list[i];}
			System.out.println("");

			System.out.println("Would you like to sort another list? (yes/no)");
			System.out.println("");
			run = kbd.nextLine();
			System.out.println("");
		}while (run.equalsIgnoreCase("yes"));

	}
}

