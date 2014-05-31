// Chris Johnson & Shawn Mbateng
// Camp Posanivee
// CS248

import java.io.*;
import java.util.*;
//CLASSPATH=$CLASSPATH:.

public class Camp
{
 public static void main(String [] args) throws IOException
 {
	Scanner file;
	int number;
	BST tree = new BST();
	String command="";

	file = new Scanner(new FileReader("CampData.txt"));

	while(command!="Q")
	{
		command=file.next();
		System.out.println("");

		if (command.equalsIgnoreCase("H")) // Help: print a list of commands
		{
			System.out.print("Command: "+command+" ");
			System.out.println("H:  Help: prints a list of commands.");
			System.out.println("E:	Enroll a New Camper");
			System.out.println("W:	Withdraw a Camper");
			System.out.println("D: 	Display the Age and Gender of a Camper");
			System.out.println("A:	Print the Average Age of the Campers");
			System.out.println("L:	List All Campers Names in Alphabetical Order");
			System.out.println("S:	Print the Number of Boy and Girl Campers");
			System.out.println("P:	List All Campers Names in Preorder");
			System.out.println("Q:	Quit");
		}
		else if (command.equalsIgnoreCase("E")) // Enroll a new camper (insert)
		{
			System.out.print("Command: "+command+" ");
			ivee camper=new ivee(file); // creates a camper from the ivee object.
			System.out.println(camper); //print name of the camper.
			tree.insert(camper); // insert the camper into the tree.
			System.out.println("New Camper Added");
		}
		else if (command.equalsIgnoreCase("W")) // Withdraw a camper (delete)
		{
			System.out.print("Command: "+command+" ");
			ivee toDelete=new ivee(file,0); // creates a toDelete from the ivee object specific to only name.
			tree.delete(toDelete); // deletes the camper from the tree.
			String removedName=toDelete.getName(); //create a string in order to print only the name of the camper.
			System.out.println("Camper "+removedName+" is Withdrawn");
		}
		else if (command.equalsIgnoreCase("D")) // Display the age and gender of a camper
		{
			System.out.println("Command: "+command);
			System.out.print("   ");
			ivee NameCamper=new ivee(file,0); // creates a NameCamper from ivee in order to use to find the specific camper.
			findCamper(tree, NameCamper); // sends the current tree and the NameCamper to the findCamper function.
		}
		else if (command.equalsIgnoreCase("A")) // Print the average age of the campers
		{
			System.out.print("Command: "+command+" ");
			averageAge(tree); // takes the current tree and sends it to the averageAge function.
		}
		else if (command.equalsIgnoreCase("L")) // List all campers names in alphabetical order
		{
			System.out.println("Command: "+command);
			alphaOrder(tree); // takes the current tree and sends it to the alphaOrder function.
		}
		else if (command.equalsIgnoreCase("S")) // Print the number of boy girl campers
		{
			System.out.println("Command: "+command);
			countCampers(tree); // takes the current tree and sends it to the countCampers function.
		}
		else if (command.equalsIgnoreCase("P")) // List all campers names in preorder
		{
			System.out.println("Command: "+command);
			preOrder(tree); // takes the current tree and sends it to the preOrder function.
		}
		else if (command.equalsIgnoreCase("Q")) // Quit
		{
		System.out.print("Command: "+command+" ");
		System.out.println("End of Program.");
		System.out.println("");
		break;
		}
	}
 }

 public static void averageAge(BST tree) // function to determine the average age of all campers.
 {
	int count=0;
	int age=0;
	ivee Sorenson= new ivee(); // create an ivee item to be used to compare data from the tree.
	tree.reset(BST.PREORDER); // place the tree in Preorder.
	if (!tree.hasNext()) // if tree is empty prints that there arent any campers.
		{ System.out.println("There are no Campers.");  }
	else
	{
		while(tree.hasNext())
		{
			count++; //counts how many campers there are
			Sorenson=(ivee)tree.getNext(); //sets the Sorenson to the getNext() of the tree.
			age+=Sorenson.getAge(); // has age add the new value from the getAge().
		}
		int average= age/count; // calculates the average by taking total age divided by number of campers.
		System.out.println("The Average Age of All the Campers is: "+average);
	}
 }

public static void findCamper(BST tree, ivee CamperName) // function that picks a certain camper and lists name, age, sex.
 {
	ivee is=new ivee(); // create an ivee item to be used to compare data from the tree.
	tree.reset(BST.PREORDER); // place the tree in Preorder.
	if (!tree.hasNext()) // if tree is empty prints that there arent any campers.
		{ System.out.println("There are no Campers.");  }
	else
	{
		while(tree.hasNext())
		{
			is=(ivee)tree.getNext(); //sets the is to the getNext() of the tree.
			if(CamperName.compareTo(is)==0) // compares the CamperName to the ivee is
				{System.out.println(is);}
		}

	}
 }

public static void alphaOrder(BST tree) // prints out the camepers in alphabetical order.
{
	String lettuce=""; // creates a string
	ivee A=new ivee(); // create an ivee item to be used to compare data from the tree.
	tree.reset(BST.INORDER); // place the tree in Inorder.
	if (!tree.hasNext()) // if tree is empty prints that there arent any campers.
		{ System.out.println("There are no Campers.");  }
	else
	{
		System.out.println("Alphabetical List of Campers: ");
		while(tree.hasNext())
		  {
			  A=(ivee)tree.getNext(); //sets the A to the getNext() of the tree.
			  lettuce=A.getName()+" "; //sets lettuce equal to the name of the ivee  A
			  System.out.println(lettuce);
		  }
	}
}

public static void countCampers(BST tree) //counts the number of boy campers and number of girl campers and gives totals.
{
	int male=0;
	int female=0;
	String pineapple=""; // creates the string pineapple
	ivee Giant=new ivee(); // create an ivee item to be used to compare data from the tree.
	tree.reset(BST.INORDER); // place the tree in Inorder.
	if (!tree.hasNext()) // if tree is empty prints that there arent any campers.
		{ System.out.println("There are no Campers.");  }
	else
	{
		System.out.println("Camper Count by Gender ");
		while(tree.hasNext())
		{
			Giant=(ivee)tree.getNext();  //sets the Giant to the getNext() of the tree.
			pineapple=Giant.getSex(); // sets pineapple equal to the Sex of Giant.
			if(pineapple.equalsIgnoreCase("M")) { male++; }	// if pineapple is male adds one.
			else if(pineapple.equalsIgnoreCase("F")) { female++; } // if pineapple is female adds one.
		}
	}
	System.out.println("The Number of Boys is: "+male);
	System.out.println("The Number of Girls is: "+female);
}

public static void preOrder(BST tree) // prints out all the campers in preorder.
{
	String cheeseburger=""; // creates the string cheesburger.
	ivee Panda=new ivee(); // create an ivee item to be used to compare data from the tree.
	tree.reset(BST.PREORDER); // place the tree in Preorder.
	if (!tree.hasNext())  // if tree is empty prints that there arent any campers.
		{ System.out.println("There are no Campers.");  }
	else
	{
		System.out.println("Preorder Traversal: ");
		while(tree.hasNext())
		  {
			  Panda=(ivee)tree.getNext(); //sets the Panda to the getNext() of the tree.
			  cheeseburger=Panda.getName()+" "; // sets cheeseburger equal to the name of Panda.
			  System.out.println(cheeseburger);
		  }
	}
}

}