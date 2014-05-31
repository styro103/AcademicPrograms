/*
Shaun Mbateng
Hill Cipher
This Program Deciphers Using the Hill Method
*/

import java.io.*;
import java.util.*;

class HC
{
	public static void main(String [] args) throws IOException
	{
		int [][] M = new int [2][2];
		int [][] I = new int [2][2];
		char [] text;
		char [] DText;
		int det;
		int Idet = 0;
		Scanner cin = new Scanner(System.in);
		Scanner kbd = new Scanner(System.in);
		Scanner infile;
		String infilename;
		String temp;
		PrintWriter outfile;
		System.out.println("");
		System.out.println("Hill Cipher Decrypter Program");
		System.out.println("");
		System.out.println("Enter file name with encrypted text.");
		infilename = kbd.nextLine();
		infile = new Scanner(new FileReader(infilename));
		outfile = new PrintWriter(new FileWriter("Text.txt"));
		System.out.println("");

		for (int i=0; i<M.length;i++)
		{
			for (int j=0; j<M.length;j++)
			{
				System.out.println("Enter encryption matrix element ("+(i+1)+","+(j+1)+")");
				M[i][j]=cin.nextInt();
			}
		}

		System.out.println("");

		for (int i=0; i<M.length;i++)
		{
			for (int j=0; j<M.length;j++)
			{
				System.out.print(M[i][j]);
				System.out.print(" ");
			}
			System.out.println("");
		}

		System.out.println("");
		det = (M[0][0]*M[1][1])-(M[0][1]*M[1][0]);

		while(det <0 || det>25)
		{
			if (det<0)
				det = (26+det)%26;
			if (det>25)
				det = det%26;
		}

		if (det%2 == 0 || det == 13)
		{
			System.out.println("Invalid determinant and matrix.");

		}
		else
		{
			System.out.println("");
			System.out.println("Check Text.txt File");
			System.out.println("");

			if (det == 3)
				Idet = 9;
			if (det == 5)
				Idet = 21;
			if (det == 7)
				Idet = 15;
			if (det == 9)
				Idet = 3;
			if (det == 11)
				Idet = 19;
			if (det == 15)
				Idet = 7;
			if (det == 17)
				Idet = 23;
			if (det == 19)
				Idet = 11;
			if (det == 21)
				Idet = 5;
			if (det == 23)
				Idet = 17;
			if (det == 1 || det == 25)
				Idet = det;

			I[0][0] = (Idet*M[1][1])%26;
			I[0][1] = (Idet*-M[0][1])%26;
			I[1][0] = (Idet*-M[1][0])%26;
			I[1][1] = (Idet*M[0][0])%26;

			for (int i=0; i<I.length;i++)
			{
				for (int j=0; j<I.length;j++)
				{
					if(I[i][j]<0)
						I[i][j] = 26+I[i][j];
				}
			}

			while (infile.hasNext())
			{
				temp = infile.nextLine();
				temp = temp.replace(" ", "");
				temp = temp.toUpperCase();
				text = temp.toCharArray();
				DText = new char [text.length];
				for (int i=0; i<text.length;i++)
				{
					if (i%2 == 0)
					{
						DText[i] = (char) ('A'+((((text[i]-'A')*I[0][0])+((text[i+1]-'A')*I[0][1]))%26));
					}
					else if (i%2 != 0)
					{
						DText[i] = (char) ('A'+((((text[i-1]-'A')*I[1][0])+((text[i]-'A')*I[1][1]))%26));
					}
				}
				System.out.println(DText);
				outfile.println(DText);
			}
			outfile.close();
		}
	}
}

