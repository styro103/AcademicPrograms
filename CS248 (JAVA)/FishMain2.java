import java.io.*;
import java.util.*;

class FishMain2
{
	static Scanner cin;
	
	public static void main(String [] args) throws IOException,NullPointerException
		{
			Fish x;
			String nom,type,cl;
			int fn;
			System.out.print("Enter the fish name. ");
			nom = cin.nextLine();
			System.out.print("What species is it? ");
			type = cin.nextLine();
			System.out.print("What color is it? ");
			cl = cin.nextLine();
			System.out.print("How many fins does it have? ");
			fn = cin.nextInt();
			
			x = new Fish(nom,type,cl,fn);
			
			System.out.println(x);
	
			while(x.getFins()>0)
			{
				x.sharkAttack();
				System.out.println("Shark Attack!!!!! Oh no!");
			}
			System.out.println(x);
			if(x.getFins()==0)
			{
				System.out.print(nom+" has no fins."+nom+" is dead. :(");
			}
		}
}