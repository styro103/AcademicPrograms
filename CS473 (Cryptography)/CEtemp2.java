/*
Shaun Mbateng & Heather Hartnagel
Classic Encryption
This Program Enciphers and Deciphers Using Various Cipher Algorithms
*/

import java.io.*;
import java.util.*;

class CE
{
	static String pt;
	static int crypt;
	static int cipher;
	static char [] text;
	static char [] keyword;
	static int shift;
	static Scanner kbd = new Scanner(System.in);
	static Scanner cin=new Scanner(System.in);
	static Scanner infile;
	static String temp;
	static String KW;
	static PrintWriter outfile;

	static int char2int(char x)
	{
	  if('a'<=x && x<='z') return x-'a';
	  if('A'<=x && x<='Z') return x-'A';
	  return -1;
	}

	static char int2char(int x)
	{
	  return (char) (x+'A');
	}

	static char encode(char x)
	{
	  int y;
	  if(('a'<=x && x<='z')||('A'<=x && x<='Z'))
	  {
		y=char2int(x);
		y=(y+shift)%26;
		return int2char(y);
	  }
	  else
		return x;
	}

	static char decode(char x)
	{
	  int y;
	  if(('a'<=x && x<='z')||('A'<=x && x<='Z'))
	  {
		y=char2int(x);
		y=(y+(26-shift))%26;
		return int2char(y);
	  }
	  else
		return x;
	}

	public static void main(String [] args) throws IOException
	{
		System.out.println("");
		System.out.print("Please enter the name of your data file: ");
		String infilename = kbd.nextLine();
		infile = new Scanner(new FileReader(infilename));
		outfile = new PrintWriter(new FileWriter("Text.txt"));
		System.out.println("");
		System.out.println("Would you Like to Encrypt (1) or Decrypt (2)?");
		crypt = cin.nextInt();
		while (crypt<1 || crypt>2)
		{
			System.out.println("");
			System.out.println("Not A Valid Answer ");
			System.out.println("Would you Like to Encrypt (1) or Decrypt (2)?");
			crypt = cin.nextInt();
		}

		System.out.println("");
		System.out.println("1. Shift Cipher") ;
		System.out.println("2. Substitution Cipher (Columnar Transposition)");
		System.out.println("3. Affine Cipher");
		System.out.println("4. Vigenere Cipher");
		System.out.println("");
		System.out.println("Pick the algorithm number you would like to use.");
		cipher = cin.nextInt();

		while (cipher<1 || cipher>4)
		{
			System.out.println("");
			System.out.println("That's Not A Valid Answer. ");
			System.out.println("Pick the algorithm number you would like to use.");
			cipher = cin.nextInt();
		}

		if (cipher == 1)
		{
			Shift();
		}
		else if (cipher == 2)
		{
			Substitution();
		}
		else if (cipher == 3)
		{
			Affine();
		}
		else if (cipher == 4)
		{
			Viginere();
		}
	}

	static void Shift() throws IOException
	{
		System.out.println("");
		System.out.println("What is the shift?");
		shift = cin.nextInt();
		System.out.println("");
		System.out.println("Check Text.txt File");

		if (crypt == 1)
		{
			System.out.println("");
			while(infile.hasNext())
			{
				temp = infile.nextLine();
				text = temp.toCharArray();
				for(int i=0; i<text.length; i++)
				{
					text[i]=encode(text[i]);
					System.out.print(text[i]);
					outfile.print(text[i]);
				}
				System.out.println("");
				outfile.println("");
			}

			System.out.println("");
			outfile.println("");
		}

		else if (crypt == 2)
		{
			System.out.println("");
			while(infile.hasNext())
			{
				temp = infile.nextLine();
				text = temp.toCharArray();
				for(int i=0; i<text.length; i++)
				{
					text[i]=decode(text[i]);
					System.out.print(text[i]);
					outfile.print(text[i]);
				}
				System.out.println("");
				outfile.println("");
			}
			System.out.println("");
			outfile.println("");
		}
		outfile.close();
	}

	static void Substitution() throws IOException
	{
		PrintWriter CToutfile = new PrintWriter(new FileWriter("CTOut.txt"));
		System.out.println("");
		System.out.println("What is the keyword?");
		KW=kbd.nextLine().replace(" ","");
		KW=KW.toLowerCase();
		System.out.println("");
		System.out.println("Check Text.txt File");
		keyword = KW.toCharArray();
		char tempKW[] = new char [keyword.length];
		for (int t=0;t<2;t++)
		{
			int tail = 0;
			for (int i=0; i<keyword.length; i++)
			{
				int j;
				for (j=0; j<tail; j++)
				{
					if (keyword[i] == keyword[j])
						break;
				}

				if (j == tail)
				{
					tempKW[j] = keyword[i]; // add
					tail++; // increment tail...[0,tail) is still "unique char list"
				}
			}
			keyword=tempKW;
		}
		for (int k=0; k<keyword.length;k++)
		{
			if (tempKW[k]=='\u0000')
			{
				keyword = new char [tempKW.length-k+1];
				break;
			}
		}
		for (int i=0; i<keyword.length;i++)
				keyword[i]=tempKW[i];
		int columns = keyword.length;
		System.out.print("Keyword Used: ");
		System.out.println(keyword);

		while(infile.hasNext())
		{
			temp=infile.nextLine().replace(" ","");
			text=temp.toCharArray();
			CToutfile.print(text);
		}
		CToutfile.close();
		infile = new Scanner(new FileReader("CTOut.txt"));
		while(infile.hasNext())
		{
			temp=infile.nextLine().replace(" ","");
			text=temp.toCharArray();
			for (int i=0; i<text.length; i=i+columns)
			{
				for (int j=0; j<columns;j++)
				{
					System.out.print(text[i+j]);
					outfile.print(text[i+j]);
				}
				System.out.println("");
				outfile.println("");
			}
			System.out.println("");
			outfile.println("");
		}
		outfile.close();
	}

	static void Affine() throws IOException
	{
	}

	static void Viginere() throws IOException
	{
	}

}