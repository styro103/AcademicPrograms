/*
Shaun Mbateng
Derby Days 2011 Program
This Program Has A Name Inputted, and Adds A Score
	Depending on What Sorority That Person is In,
	If She is in One. It Also Adds an Additional Point
	For Every Freshman Boy Brought by A Sorority
*/

import java.io.*;
import java.util.*;

class DerbyDays2011
{
	static int ACOs,ACOf;
	static int APs,APf;
	static int DGs,DGf;
	static int DDDs,DDDf;
	static int KATs,KATf;
	static int KKGs,KKGf;
	static int PBPs,PBPf;
	static int ICs,ICf;
	static String Sorority;
	static String name/*,tname*/;
	static PrintWriter outfile;

	static String Y="yes";
	static String X;

	// Use .replace(" ","") after name and temp to Ignore Spaces, but Will Ignore Middle Space as Well //

	public static void main(String [] args) throws IOException
	{
		do{
			Scanner kbd = new Scanner(System.in);
			Scanner cin=new Scanner(System.in);
			outfile = new PrintWriter(new FileWriter("TodayScore.txt"));
			System.out.println("");
			System.out.println("Please enter the name of the person. ");
			name = kbd.nextLine();
			System.out.println("");
			AlphaChi();
			AlphaPhi();
			DeltaGamma();
			TriDelta();
			Theta();
			Kappa();
			PiPhi();
			Independent();
			System.out.println("Alpha Chi has a score and freshman score of "+ACOs+" and "+ACOf+" respectively.");
			System.out.println("Alpha Phi has a score and freshman score of "+APs+" and "+APf+" respectively.");
			System.out.println("Delta Gamma has a score and freshman score of "+DGs+" and "+DGf+" respectively.");
			System.out.println("Tri-Delta has a score and freshman score of "+DDDs+" and "+DDDf+" respectively.");
			System.out.println("Theta has a score and freshman score of "+KATs+" and "+KATf+" respectively.");
			System.out.println("Kappa has a score and freshman score of "+KKGs+" and "+KKGf+" respectively.");
			System.out.println("Pi Phi has a score and freshman score of "+PBPs+" and "+PBPf+" respectively.");
			System.out.println("Independent Council has a score and freshman score of "+ICs+" and "+ICf+" respectively.");
			System.out.println("");
			System.out.println("Enter another name? Type yes or no.");
			X = kbd.nextLine();
			if(X.replace(" ","").equalsIgnoreCase("no"))
			{
				System.out.println("");
				//outfile.println("");
				System.out.println("Final Scores Today:");
				outfile.println("Final Scores Today:");
				System.out.println("Alpha Chi has a score and freshman score of "+ACOs+" and "+ACOf+" respectively.");
				outfile.println("Alpha Chi has a score and freshman score of "+ACOs+" and "+ACOf+" respectively.");
				System.out.println("Alpha Phi has a score and freshman score of "+APs+" and "+APf+" respectively.");
				outfile.println("Alpha Phi has a score and freshman score of "+APs+" and "+APf+" respectively.");
				System.out.println("Delta Gamma has a score and freshman score of "+DGs+" and "+DGf+" respectively.");
				outfile.println("Delta Gamma has a score and freshman score of "+DGs+" and "+DGf+" respectively.");
				System.out.println("Tri-Delta has a score and freshman score of "+DDDs+" and "+DDDf+" respectively.");
				outfile.println("Tri-Delta has a score and freshman score of "+DDDs+" and "+DDDf+" respectively.");
				System.out.println("Theta has a score and freshman score of "+KATs+" and "+KATf+" respectively.");
				outfile.println("Theta has a score and freshman score of "+KATs+" and "+KATf+" respectively.");
				System.out.println("Kappa has a score and freshman score of "+KKGs+" and "+KKGf+" respectively.");
				outfile.println("Kappa has a score and freshman score of "+KKGs+" and "+KKGf+" respectively.");
				System.out.println("Pi Phi has a score and freshman score of "+PBPs+" and "+PBPf+" respectively.");
				outfile.println("Pi Phi has a score and freshman score of "+PBPs+" and "+PBPf+" respectively.");
				System.out.println("Independent Council has a score and freshman score of "+ICs+" and "+ICf+" respectively.");
				outfile.println("Independent Council has a score and freshman score of "+ICs+" and "+ICf+" respectively.");
				System.out.println("");
				outfile.close();
				Y=X;
			}
			else if (X.replace(" ","").equalsIgnoreCase("yes"))
			{
				Y=X;
			}
			while (!X.replace(" ","").equalsIgnoreCase("yes") && !X.replace(" ","").equalsIgnoreCase("no"))
			{
				System.out.println("That's not an option. Type yes or no.");
				System.out.println("");
				X = kbd.nextLine();

			}
		}while(Y.replace(" ","").equalsIgnoreCase("yes"));
	}

	static void AlphaChi() throws IOException
	{
		Sorority = "ACO.txt";
		Scanner sfile = new Scanner(new FileReader(Sorority));
		String filename = sfile.nextLine();
		String temp;
		ArrayList<String> ACO = new ArrayList<String>();

		while(sfile.hasNext())
		{
			temp = sfile.nextLine();
			ACO.add(temp);
			if(name.equalsIgnoreCase(temp))
				ACOs++;
		}

		if(name.equalsIgnoreCase("Alpha Chi Omega"))
			ACOf++;
		if(name.equalsIgnoreCase("Alpha Chi"))
			ACOf++;
		if(name.equalsIgnoreCase("ACO"))
			ACOf++;
		if(name.equalsIgnoreCase("ACO--"))
			ACOs--;
	}

	static void AlphaPhi() throws IOException
	{
		Sorority = "AP.txt";
		Scanner sfile = new Scanner(new FileReader(Sorority));
		String filename = sfile.nextLine();
		String temp;
		ArrayList<String> AP = new ArrayList<String>();

		while(sfile.hasNext())
		{
			temp = sfile.nextLine();
			AP.add(temp);
			if(name.equalsIgnoreCase(temp))
				APs++;
		}

		if(name.equalsIgnoreCase("Alpha Phi"))
			APf++;
		if(name.equalsIgnoreCase("AP"))
			APf++;
		if(name.equalsIgnoreCase("AP--"))
			APs--;
	}

	static void DeltaGamma() throws IOException
	{
		Sorority = "DG.txt";
		Scanner sfile = new Scanner(new FileReader(Sorority));
		String filename = sfile.nextLine();
		String temp;
		ArrayList<String> DG = new ArrayList<String>();

		while(sfile.hasNext())
		{
			temp = sfile.nextLine();
			DG.add(temp);
			if(name.equalsIgnoreCase(temp))
				DGs++;
		}

		if(name.equalsIgnoreCase("Delta Gamma"))
			DGf++;
		if(name.equalsIgnoreCase("DG"))
			DGf++;
		if(name.equalsIgnoreCase("DG--"))
			DGs--;
	}

	static void TriDelta() throws IOException
	{
		Sorority = "DDD.txt";
		Scanner sfile = new Scanner(new FileReader(Sorority));
		String filename = sfile.nextLine();
		String temp;
		ArrayList<String> DDD = new ArrayList<String>();

		while(sfile.hasNext())
		{
			temp = sfile.nextLine();
			DDD.add(temp);
			if(name.equalsIgnoreCase(temp))
				DDDs++;
		}

		if(name.equalsIgnoreCase("Delta Delta Delta"))
			DDDf++;
		if(name.equalsIgnoreCase("Tri-Delta"))
			DDDf++;
		if(name.equalsIgnoreCase("TriDelta"))
			DDDf++;
		if(name.equalsIgnoreCase("Tri Delta"))
			DDDf++;
		if(name.equalsIgnoreCase("DDD"))
			DDDf++;
		if(name.equalsIgnoreCase("DDD--"))
			DDDs--;
	}

	static void Theta() throws IOException
	{
		Sorority = "KAT.txt";
		Scanner sfile = new Scanner(new FileReader(Sorority));
		String filename = sfile.nextLine();
		String temp;
		ArrayList<String> KAT = new ArrayList<String>();

		while(sfile.hasNext())
		{
			temp = sfile.nextLine();
			KAT.add(temp);
			if(name.equalsIgnoreCase(temp))
				KATs++;
		}

		if(name.equalsIgnoreCase("Theta"))
			KATf++;
		if(name.equalsIgnoreCase("Kappa Alpha Theta"))
			KATf++;
		if(name.equalsIgnoreCase("KAT"))
			KATf++;
		if(name.equalsIgnoreCase("KAT--"))
			KATs--;
	}

	static void Kappa() throws IOException
	{
		Sorority = "KKG.txt";
		Scanner sfile = new Scanner(new FileReader(Sorority));
		String filename = sfile.nextLine();
		String temp;
		ArrayList<String> KKG = new ArrayList<String>();

		while(sfile.hasNext())
		{
			temp = sfile.nextLine();
			KKG.add(temp);
			if(name.equalsIgnoreCase(temp))
				KKGs++;
		}

		if(name.equalsIgnoreCase("Kappa Kappa Gamma"))
			KKGf++;
		if(name.equalsIgnoreCase("Kappa"))
			KKGf++;
		if(name.equalsIgnoreCase("KKG"))
			KKGf++;
		if(name.equalsIgnoreCase("KKG--"))
			KKGs--;
	}

	static void PiPhi() throws IOException
	{
		Sorority = "PBP.txt";
		Scanner sfile = new Scanner(new FileReader(Sorority));
		String filename = sfile.nextLine();
		String temp;
		ArrayList<String> PBP = new ArrayList<String>();

		while(sfile.hasNext())
		{
			temp = sfile.nextLine();
			PBP.add(temp);
			if(name.equalsIgnoreCase(temp))
				PBPs++;
		}

		if(name.equalsIgnoreCase("Pi Beta Phi"))
			PBPf++;
		if(name.equalsIgnoreCase("Pi Phi"))
			PBPf++;
		if(name.equalsIgnoreCase("PBP"))
			PBPf++;
		if(name.equalsIgnoreCase("PBP--"))
			PBPs--;
	}

	static void Independent() throws IOException
	{
		Sorority = "IC.txt";
		Scanner sfile = new Scanner(new FileReader(Sorority));
		String filename = sfile.nextLine();
		String temp;
		ArrayList<String> IC = new ArrayList<String>();

		while(sfile.hasNext())
		{
			temp = sfile.nextLine();
			IC.add(temp);
			if(name.equalsIgnoreCase(temp))
				ICs++;
		}

		if(name.equalsIgnoreCase("Independent Council"))
			ICf++;
		if(name.equalsIgnoreCase("IC"))
			ICf++;
		if(name.equalsIgnoreCase("GDI"))
			ICf++;
		if(name.equalsIgnoreCase("Independent"))
			ICf++;
		if(name.equalsIgnoreCase("IC--"))
			ICs--;
	}
}