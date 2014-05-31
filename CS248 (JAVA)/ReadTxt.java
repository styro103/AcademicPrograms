import java.io.*;
import java.util.*;

class ReadTxt
{
  static Scanner infile, kbd;
  static PrintWriter outfile;
  
  public static void main (String [] args) throws IOException
  {
    String infilename,outfilename;
	
	kbd = new Scanner(System.in);
	System.out.print("Please enter the input file name: ");
	infilename = kbd.nextLine();
	System.out.print("Please enter the output file name: ");
	outfilename = kbd.nextLine();
	
	infile = new Scanner(new FileReader(infilename));
	
	outfile = new PrintWriter(new FileWriter(outfilename));
	
	// read file and print on the screen
	String line;
	while(infile.hasNextLine())
	{
	  line = infile.nextLine();
	  line = encrypt(line);
	  outfile.println(line);
	}
	outfile.close();
  }
  
  static String encrypt(String x)
  {
    String y="";
	for(int i=0; i<x.length(); i++)
	{
	  char c = x.charAt(i);
	  if('a'<=c && c<='z') // lowercase letter
	  {
	    c=(char) (c+13);
		if(c>'z') c=(char) (c-26);
		y=y+c;
	  }
	  else if('A'<=c && c<='Z') // lowercase letter
	  {
	    c=(char) (c+13);
		if(c>'Z') c=(char) (c-26);
		y=y+c;
	  }
	  else y=y+c;
	}
	
    return y;
  }
}
