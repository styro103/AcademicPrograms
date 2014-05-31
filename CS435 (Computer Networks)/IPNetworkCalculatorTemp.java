/*
Shaun Mbateng
CS 435 Fall 2012
Project 2 Sub A: IP Network Calculator
Due: December 14th before 5 P.M.
100 points
*/

import java.io.*;
import java.util.*;
import java.text.*;

public class IPNetworkCalculatorTemp
{
	static Scanner kbd; //To Enter Strings
	//static Scanner cin; //To enter Integers
	static int a,b,c,d,x; //Each Will Hold A Number From Address
	static String Address1; //Address String
	static String [] Address2; //String Array of Address
	static String [] BIP = new String [4]; //Holds the Binary Values of IP Address
	static int n; //This Will Hold the Number of Network Addresses
	static String [] NA = new String [4]; //This Will Hold the Calculated Network Address
	static String Network; //This Will Hold the Network Address in A String
	static String [] BA = new String [4]; //This Will Hold the Calculated Broadcast Address
	static String Broadcast; //This Will Hold the Broadcast Address in A String
	static String List = "Not Sure"; //String to Ask User to List All Addresses
	static String Repeat = "Yes"; //String to Repeat Program

	public static void main(String [] args) throws IOException
	{
		Intro(); //Intro Function

		while (Repeat.equalsIgnoreCase("Yes"))
		{
			int pc = 0; //Period Counter
			int sc = 0; //Slash Counter
			kbd = new Scanner(System.in); // To Input Strings
			//cin=new Scanner(System.in); // To Input Integers
			System.out.println("Please input the CIDR Network Address (in the Form a.b.c.d/x)"); //Ask for Address
			Address1 = kbd.nextLine(); //Input Address As String
			for (int i=0; i<Address1.length(); i++)
			{
				if (Address1.charAt(i) == '.') //Count Period Number
					pc++;
				if (Address1.charAt(i) == '/') //Count Slash Number
					sc++;
			}
			while (pc !=3 || sc !=1) //If Not Correct Amount, Not Correct Form
			{
				pc = 0; //Reset Counter to Zero
				sc = 0; //Reset Counter to Zero

				System.out.println(""); //Space
				System.out.println("Please Reenter, Network Address Must be in Form a.b.c.d/x");
				Address1 = kbd.nextLine(); //Input Address As String
				for (int i=0; i<Address1.length(); i++)
				{
					if (Address1.charAt(i) == '.')
						pc++;
					if (Address1.charAt(i) == '/')
						sc++;
				}
			}
			Address1 = Address1.replace("/","."); //Replace "/" With "."
			Address1 = Address1.replace(".",":"); //Replace "." With ":"
			System.out.println("");
			Address2 = Address1.split(":"); //Split String Into String Array Seperated by ":"

			Calculations(); //Calculations Function
			ListAddresses(); //List Addresses Function
		}
	}

	static void Intro() //Displays Introduction to Program
	{
		System.out.println("");
		System.out.println("**IP Network Calculator**");
		System.out.println("This Program Takes A CIDR Network Address");
		System.out.println("and Calculates the Network Address, Broadcast Address,");
		System.out.println("Number of addresses in the network, and Can");
		System.out.println("List All the Addresses in the Network.");
		System.out.println("");
	}

	static void Calculations() //Calculates Addresses
	{
		a = Integer.parseInt(Address2[0]); //Convert First String to Integer, Store in a
		b = Integer.parseInt(Address2[1]); //Convert Second String to Integer, Store in b
		c = Integer.parseInt(Address2[2]); //Convert Third String to Integer, Store in c
		d = Integer.parseInt(Address2[3]); //Convert Fourth String to Integer, Store in d
		x = Integer.parseInt(Address2[4]); //Convert Fifth String to Integer, Store in x
		n = (int)Math.pow(2,32-x); //Calculate Number of Network Addresses
		BIP[0] = Integer.toBinaryString(a); //Convert a to Binary
		BIP[1] = Integer.toBinaryString(b); //Convert b to Binary
		BIP[2] = Integer.toBinaryString(c); //Convert c to Binary
		BIP[3] = Integer.toBinaryString(d); //Convert d to Binary
		for (int i=0;i<4;i++)
		{
			while (BIP[i].length()!=8)
			{
				BIP[i] = "0"+BIP[i]; //Make String 8-Bit Binary Value
			}
		}
		String s = BIP[0]+BIP[1]+BIP[2]+BIP[3]; //String s Now Holds Binary String of All Numbers
		String net = s.substring(0,x); //net is Last x Bits of s
		String bcast = net; //bcast is equal to net
		while (net.length()!=32)
			net = net + "0"; //Add Bits to Make 32-Bit
		while (bcast.length()!=32)
			bcast = bcast + "1"; //Add Bits to Make 32-Bit
		//s = s.substring(0,x)+":"+s.substring(x,s.length());
		net = net.substring(0,8)+":"+net.substring(8,16)+":"+net.substring(16,24)+":"+net.substring(24,net.length()); //Insert ";" After Every 8-Bits
		bcast = bcast.substring(0,8)+":"+bcast.substring(8,16)+":"+bcast.substring(16,24)+":"+bcast.substring(24,bcast.length()); //Insert ";" After Every 8-Bits
		NA = net.split(":"); //Make Array Split By ":"
		BA = bcast.split(":"); //Make Array Split By ":"
		for (int i=0;i<4;i++)
		{
			NA[i] = String.format("%d",Integer.parseInt(NA[i],2)); //Convert Binary Numbers to Decimal
			BA[i] = String.format("%d",Integer.parseInt(BA[i],2)); //convert Binary Numbers to Decimal
		}
		Network = NA[0]+"."+NA[1]+"."+NA[2]+"."+NA[3]; //String of Address Separated With "."
		Broadcast = BA[0]+"."+BA[1]+"."+BA[2]+"."+BA[3]; //String of Address Separated With "."
	}

	static void ListAddresses() //Lists Network Addresses
	{
		System.out.println("Network Address:");
		System.out.println(Network); //Display Network Address
		System.out.println("");
		System.out.println("Broadcast Address:");
		System.out.println(Broadcast); //Display Broadcast Address
		System.out.println("");
		System.out.println("Number of Network Addresses:");
		System.out.println(n); //Display Network Address Number
		System.out.println("");
		System.out.println("Would You Like to See All the Addresses in the Network? (yes/no)");
		List = kbd.nextLine();
		System.out.println("");
		while (!List.equalsIgnoreCase("yes") && !List.equalsIgnoreCase("no")) //Loops Until Answer is Yes or No
		{
			System.out.println("Please Enter ''yes'' or ''no''");
			List = kbd.nextLine();
			System.out.println("");
		}

		if (List.replace(" ","").equalsIgnoreCase("yes")) //If Answer is Yes
		{
			System.out.println("Here They Are:");
			System.out.println("");
		}
		System.out.println("Would You Like to Enter Another IP Address? (yes/no)");
		Repeat = kbd.nextLine();
		System.out.println("");
		while (!Repeat.equalsIgnoreCase("yes") && !Repeat.equalsIgnoreCase("no")) //Loops Until Answer is Yes or No
		{
			System.out.println("Please Enter ''yes'' or ''no''");
			Repeat = kbd.nextLine();
			System.out.println("");
		}
	}
}