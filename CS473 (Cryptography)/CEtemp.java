/*
Shaun Mbateng & Heather Hartnagel
Classic Encryption
This Program Enciphers and Deciphers Using Various Cipher Algorithms
*/

import java.io.*;
import java.util.*;

class CEtemp
{
	static String pt;
	static int crypt;
	static int cipher;
	static int a,b,c,d;
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
		y=(a*y+shift)%26;
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
		y=(c*y+(26-shift))%26;
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
		System.out.println("4. Vigenère Cipher");
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
			Vigenère();
		}
	}

	static void Shift() throws IOException
	{
		a = 1;
		c = 1;
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
		System.out.println("");
		keyword = KW.toCharArray();
		char tempKW[] = new char [keyword.length];
		for (int i=0; i<keyword.length;i++)
		{
			for (int j=0; j<keyword.length;j++)
			{
				if (keyword[j]==keyword[i] && i!=j)
					keyword[j] = '\u0000';
			}
		}
		tempKW = keyword;
		for (int i=0; i<tempKW.length;i++)
		{
			if (tempKW[i]=='\u0000')
			{
				int j=i;
				while (tempKW[j]=='\u0000' && j!=tempKW.length-1)
					j++;
				char ctemp = tempKW[i];
				tempKW[i]=tempKW[j];
				tempKW[j]=ctemp;
			}
		}
		int length = tempKW.length;
		for (int k=0; k<tempKW.length;k++)
		{
			if (tempKW[k]=='\u0000')
			{
				length--;
			}
		}
		keyword = new char [length];
		for (int i=0; i<keyword.length;i++)
		{
				if (tempKW[i] != '\u0000')
					keyword[i]=tempKW[i];
		}
		int columns = keyword.length;
		System.out.print("Keyword Used: ");
		System.out.println(keyword);
		System.out.println("");
		KW=new String(keyword);
		KW=KW+"abcdefghijklmnopqrstuvwxyz";
		keyword=KW.toCharArray();
		char tempKW2[] = new char [keyword.length];
		for (int i=0; i<keyword.length;i++)
		{
			for (int j=0; j<keyword.length;j++)
			{
				if (keyword[j]==keyword[i] && i!=j)
				{
					keyword[j] = '\u0000';
				}
			}
		}
		tempKW2 = keyword;
		for (int i=0; i<tempKW2.length;i++)
		{
			if (tempKW2[i]=='\u0000')
			{
				int j=i;
				while (tempKW2[j]=='\u0000' && j!=tempKW2.length-1)
					j++;
				char ctemp = tempKW2[i];
				tempKW2[i]=tempKW2[j];
				tempKW2[j]=ctemp;
			}
		}
		length = tempKW2.length;
		for (int k=0; k<tempKW2.length;k++)
		{
			if (tempKW2[k]=='\u0000')
			{
				length--;
			}
		}
		keyword = new char [length];
		for (int i=0; i<keyword.length;i++)
		{
				if (tempKW2[i] != '\u0000')
					keyword[i]=tempKW2[i];
		}
		char CT [] = new char [keyword.length];
		if (keyword.length%columns!=0)
		{
			int r = keyword.length%columns;
			CT = new char [keyword.length+(columns-r)];
			for (int i=0; i<keyword.length; i++)
				CT[i] = keyword[i];
		}
		else if (keyword.length%columns==0)
		{
			for (int i=0; i<keyword.length; i++)
				CT[i] = keyword[i];
		}

		for (int i=0; i<CT.length; i=i+columns)
		{
			for (int j=0; j<columns;j++)
			{
				System.out.print(CT[i+j]);
			}
			System.out.println("");
		}
		System.out.println("");


		char [] tCT = new char [CT.length];
		for (int i=0; i<columns; i++)
		{
			for (int j=0; j<CT.length;j=j+columns)
			{
				CToutfile.print(CT[i+j]);
			}
		}
		CToutfile.close();

		Scanner CTinfile = new Scanner(new FileReader("CTOut.txt"));
		while (CTinfile.hasNext())
		{
			temp = CTinfile.nextLine();
			tCT = temp.toCharArray();
		}

		for (int i=0; i<tCT.length;i++)
		{
			if (tCT[i]=='\u0000')
			{
				int j=i;
				while (tCT[j]=='\u0000' && j!=tCT.length-1)
					j++;
				char ctemp = tCT[i];
				tCT[i]=tCT[j];
				tCT[j]=ctemp;
			}
		}


		while (infile.hasNext())
		{
			temp = infile.nextLine();
			temp = temp.toLowerCase();
			text = temp.toCharArray();
			if (crypt==1)
			{
				for (int i=0; i<text.length;i++)
				{

					if (text[i]=='a')
					{
						System.out.print(tCT[0]);
						outfile.print(tCT[0]);
					}
					else if (text[i]=='b')
					{
						System.out.print(tCT[1]);
						outfile.print(tCT[1]);
					}
					else if (text[i]=='c')
					{
						System.out.print(tCT[2]);
						outfile.print(tCT[2]);
					}
					else if (text[i]=='d')
					{
						System.out.print(tCT[3]);
						outfile.print(tCT[3]);
					}
					else if (text[i]=='e')
					{
						System.out.print(tCT[4]);
						outfile.print(tCT[4]);
					}
					else if (text[i]=='f')
					{
						System.out.print(tCT[5]);
						outfile.print(tCT[5]);
					}
					else if (text[i]=='g')
					{
						System.out.print(tCT[6]);
						outfile.print(tCT[6]);
					}
					else if (text[i]=='h')
					{
						System.out.print(tCT[7]);
						outfile.print(tCT[7]);
					}
					else if (text[i]=='i')
					{
						System.out.print(tCT[8]);
						outfile.print(tCT[8]);
					}
					else if (text[i]=='j')
					{
						System.out.print(tCT[9]);
						outfile.print(tCT[9]);
					}
					else if (text[i]=='k')
					{
						System.out.print(tCT[10]);
						outfile.print(tCT[10]);
					}
					else if (text[i]=='l')
					{
						System.out.print(tCT[11]);
						outfile.print(tCT[11]);
					}
					else if (text[i]=='m')
					{
						System.out.print(tCT[12]);
						outfile.print(tCT[12]);
					}
					else if (text[i]=='n')
					{
						System.out.print(tCT[13]);
						outfile.print(tCT[13]);
					}
					else if (text[i]=='o')
					{
						System.out.print(tCT[14]);
						outfile.print(tCT[14]);
					}
					else if (text[i]=='p')
					{
						System.out.print(tCT[15]);
						outfile.print(tCT[15]);
					}
					else if (text[i]=='q')
					{
						System.out.print(tCT[16]);
						outfile.print(tCT[16]);
					}
					else if (text[i]=='r')
					{
						System.out.print(tCT[17]);
						outfile.print(tCT[17]);
					}
					else if (text[i]=='s')
					{
						System.out.print(tCT[18]);
						outfile.print(tCT[18]);
					}
					else if (text[i]=='t')
					{
						System.out.print(tCT[19]);
						outfile.print(tCT[19]);
					}
					else if (text[i]=='u')
					{
						System.out.print(tCT[20]);
						outfile.print(tCT[20]);
					}
					else if (text[i]=='v')
					{
						System.out.print(tCT[21]);
						outfile.print(tCT[21]);
					}
					else if (text[i]=='w')
					{
						System.out.print(tCT[22]);
						outfile.print(tCT[22]);
					}
					else if (text[i]=='x')
					{
						System.out.print(tCT[23]);
						outfile.print(tCT[23]);
					}
					else if (text[i]=='y')
					{
						System.out.print(tCT[24]);
						outfile.print(tCT[24]);
					}
					else if (text[i]=='z')
					{
						System.out.print(tCT[25]);
						outfile.print(tCT[25]);
					}
					else if (text[i]==' ')
					{
						System.out.print(" ");
						outfile.print(" ");
					}
					else if (text[i]=='\u0000')
					{
						System.out.print(" ");
						outfile.print(" ");
					}
				}
				System.out.println("");
				outfile.println("");
			}
			else if (crypt==2)
			{
				for (int j=0; j<text.length;j++)
				{
					if (text[j]==' ')
					{
						System.out.print(' ');
						outfile.print(' ');
					}
					else if (text[j]=='\u0000')
					{
						System.out.print(" ");
						outfile.print(" ");
					}
					for (int i=0; i<tCT.length;i++)
					{
						if (text[j]==tCT[i] && text[j]!=' ' && text[j]!='\u0000')
						{
							if (i==0)
							{
								System.out.print('A');
								outfile.print('A');
							}
							else if (i==1)
							{
								System.out.print('B');
								outfile.print('B');
							}
							else if (i==2)
							{
								System.out.print('C');
								outfile.print('C');
							}
							else if (i==3)
							{
								System.out.print('D');
								outfile.print('D');
							}
							else if (i==4)
							{
								System.out.print('E');
								outfile.print('E');
							}
							else if (i==5)
							{
								System.out.print('F');
								outfile.print('F');
							}
							else if (i==6)
							{
								System.out.print('G');
								outfile.print('G');
							}
							else if (i==7)
							{
								System.out.print('H');
								outfile.print('H');
							}
							else if (i==8)
							{
								System.out.print('I');
								outfile.print('I');
							}
							else if (i==9)
							{
								System.out.print('J');
								outfile.print('J');
							}
							else if (i==10)
							{
								System.out.print('K');
								outfile.print('K');
							}
							else if (i==11)
							{
								System.out.print('L');
								outfile.print('L');
							}
							else if (i==12)
							{
								System.out.print('M');
								outfile.print('M');
							}
							else if (i==13)
							{
								System.out.print('N');
								outfile.print('N');
							}
							else if (i==14)
							{
								System.out.print('O');
								outfile.print('O');
							}
							else if (i==15)
							{
								System.out.print('P');
								outfile.print('P');
							}
							else if (i==16)
							{
								System.out.print('Q');
								outfile.print('Q');
							}
							else if (i==17)
							{
								System.out.print('R');
								outfile.print('R');
							}
							else if (i==18)
							{
								System.out.print('S');
								outfile.print('S');
							}
							else if (i==19)
							{
								System.out.print('T');
								outfile.print('T');
							}
							else if (i==20)
							{
								System.out.print('U');
								outfile.print('U');
							}
							else if (i==21)
							{
								System.out.print('V');
								outfile.print('V');
							}
							else if (i==22)
							{
								System.out.print('W');
								outfile.print('W');
							}
							else if (i==23)
							{
								System.out.print('X');
								outfile.print('X');
							}
							else if (i==24)
							{
								System.out.print('Y');
								outfile.print('Y');
							}
							else if (i==25)
							{
								System.out.print('Z');
								outfile.print('Z');
							}

						}
					}
				}
				System.out.println("");
				outfile.println("");
			}
		}
		outfile.close();
	}

	static void Affine() throws IOException
	{
		if (crypt==1)
		{
			System.out.println("");
			System.out.println("E(x) = ax+b mod 26");
			System.out.println("What is a?");
			a=cin.nextInt();
			System.out.println("What is b?");
			b=cin.nextInt();
			shift=b;
			System.out.println("");
			System.out.println("Check Text.txt File");
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
		else if (crypt==2)
		{
			System.out.println("");
			System.out.println("D(y) = cy+d mod 26");
			System.out.println("What is c?");
			c=cin.nextInt();
			System.out.println("What is d?");
			d=cin.nextInt();
			shift=26-d;
			System.out.println("");
			System.out.println("Check Text.txt File");
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

	static void Vigenère() throws IOException
	{
		a=1;
		c=1;
		Scanner Vinfile;
		PrintWriter Voutfile;
		Voutfile = new PrintWriter(new FileWriter("VOut.txt"));
		System.out.println("What is the keyword?");
		KW=kbd.nextLine().replace(" ","");
		System.out.println("");
		System.out.println("Check Text.txt File");
		System.out.println("");
		KW=KW.toLowerCase();
		keyword = KW.toCharArray();
		char [] VKW;
		int length;
		char [] VText;

		/*while(infile.hasNext())
		{
			temp=infile.nextLine();
			text=temp.toCharArray();
			length = text.length;
			temp=temp.replace(" ","");
			Voutfile.println(temp);
		}*/

		/*Voutfile.close();
		Vinfile = new Scanner(new FileReader("VOut.txt"));*/

		while (infile.hasNext())
		{
			temp=infile.nextLine();
			temp=temp.toLowerCase();
			VText=temp.toCharArray();
			temp=temp.replace(" ","");
			text=temp.toCharArray();
			ArrayList FText=new ArrayList(text.length);
			VKW = new char[text.length];
			if (text.length<=keyword.length)
			{
				for (int i=0; i<VKW.length; i++)
				{
					VKW[i]=keyword[i];
				}
				for (int i=0; i<text.length;i++)
				{
					shift = VKW[i]-'a';
					if (text[i]==' ' || text[i]=='\u0000')
					{
						System.out.print(' ');
						outfile.print(' ');
					}
					else if (text[i]!=' ' && text[i]!='\u0000')
					{
						if (crypt==1)
						{
							text[i]=encode(text[i]);
							FText.add(text[i]);
							//System.out.print(text[i]);
							//outfile.print(text[i]);
						}
						else if (crypt==2)
						{
							text[i]=decode(text[i]);
							FText.add(text[i]);
							//System.out.print(text[i]);
							//outfile.print(text[i]);
						}
					}
				}

			}
			else if (text.length>keyword.length)
			{
				for (int i=0; i<keyword.length; i++)
				{
					VKW[i]=keyword[i];
				}
				for (int i=keyword.length; i<VKW.length; i++)
				{
					VKW[i]=keyword[i-(i/keyword.length)*keyword.length];
				}
				for (int i=0; i<text.length;i++)
				{
					shift = VKW[i]-'a';
					if (text[i]==' ' || text[i]=='\u0000')
					{
						//System.out.print(' ');
						//outfile.print(' ');
					}
					else if (text[i]!=' ' && text[i]!='\u0000')
					{
						if (crypt==1)
						{
							text[i]=encode(text[i]);
							FText.add(text[i]);
							//System.out.print(text[i]);
							//outfile.print(text[i]);
						}
						else if (crypt==2)
						{
							text[i]=decode(text[i]);
							FText.add(text[i]);
							//System.out.print(text[i]);
							//outfile.print(text[i]);
						}
					}
				}
			}
			for (int i=0; i<VText.length;i++)
			{
					if (VText[i]=='\u0000' || VText[i]==' ')
						FText.add(i," ");
			}
			for (int i=0; i<FText.size(); i++)
			{
				System.out.print(FText.get(i));
				outfile.print(FText.get(i));
			}
			System.out.println("");
		}
		outfile.close();
	}
}