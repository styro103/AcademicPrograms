/*
Shaun Mbateng
Signature Method
This Program Deciphers Computes the A and V Values Using the Signature Method
*/

import java.io.*;
import java.util.*;

class Signature
{
	public static void main(String [] args) throws IOException
	{
		int KWL; //Keyword Length
		double a = 0; //A count
		double Aa = 0; //Average of a's
		double Va = 0; //Frequency Value of a
		double b = 0; //And so on
		double Ab = 0;
		double Vb = 0;
		double c = 0;
		double Ac = 0;
		double Vc = 0;
		double d = 0;
		double Ad = 0;
		double Vd = 0;
		double e = 0;
		double Ae = 0;
		double Ve = 0;
		double f = 0;
		double Af = 0;
		double Vf = 0;
		double g = 0;
		double Ag = 0;
		double Vg = 0;
		double h = 0;
		double Ah = 0;
		double Vh = 0;
		double i = 0;
		double Ai = 0;
		double Vi = 0;
		double j = 0;
		double Aj = 0;
		double Vj = 0;
		double k = 0;
		double Ak = 0;
		double Vk = 0;
		double l = 0;
		double Al = 0;
		double Vl = 0;
		double m = 0;
		double Am = 0;
		double Vm = 0;
		double n = 0;
		double An = 0;
		double Vn = 0;
		double o = 0;
		double Ao = 0;
		double Vo = 0;
		double p = 0;
		double Ap = 0;
		double Vp = 0;
		double q = 0;
		double Aq = 0;
		double Vq = 0;
		double r = 0;
		double Ar = 0;
		double Vr = 0;
		double s = 0;
		double As = 0;
		double Vs = 0;
		double t = 0;
		double At = 0;
		double Vt = 0;
		double u = 0;
		double Au = 0;
		double Vu = 0;
		double v = 0;
		double Av = 0;
		double Vv = 0;
		double w = 0;
		double Aw = 0;
		double Vw = 0;
		double x = 0;
		double Ax = 0;
		double Vx = 0;
		double y = 0;
		double Ay = 0;
		double Vy = 0;
		double z = 0;
		double Az = 0;
		double Vz = 0;
		double N = 0;
		char [] cosets;
		char [] tcosets;
		Scanner cin = new Scanner(System.in);
		Scanner kbd = new Scanner(System.in);
		Scanner infile;
		String infilename;
		Scanner Sinfile;
		Scanner Cfile;
		PrintWriter Soutfile;
		PrintWriter SOfile;
		String temp;

		System.out.println("");
		System.out.println("Signature Method Program");
		System.out.println("");
		System.out.println("Enter file name with encrypted text.");
		infilename = kbd.nextLine();
		infile = new Scanner(new FileReader(infilename));
		System.out.println("Enter the Keyword Length to Try.");
		KWL = cin.nextInt();
		Soutfile = new PrintWriter(new FileWriter("SigOut.txt"));
		SOfile = new PrintWriter(new FileWriter("SO.txt"));
		System.out.println("");

		while (infile.hasNext())
		{
			temp = infile.nextLine();
			temp = temp.toLowerCase();
			temp = temp.replace(" ","");
			Soutfile.print(temp);
		}

		Soutfile.close();
		Sinfile = new Scanner(new FileReader("SigOut.txt"));
		System.out.println("Cosets:");

		while (Sinfile.hasNext())
		{
			temp = Sinfile.nextLine();
			int remainder = temp.length()%KWL;
			tcosets = new char [temp.length()+(KWL-remainder)]; //Sets tcosets length equal to a multiple of the keyword length
			cosets = new char [tcosets.length];

			for (int one=0; one<temp.length(); one++)
				tcosets[one] = temp.charAt(one);

			for (int one=0; one<KWL; one++)
			{
				for (int two=0; two<tcosets.length;two=two+KWL)
				{
					System.out.print(tcosets[one+two]); //Prints cosets of text
					SOfile.print(tcosets[one+two]); // outfiles cosets of text
				}
				System.out.println("");
				SOfile.println("");
			}
			System.out.println("");
			SOfile.println("");
		}

		SOfile.close();

		Cfile = new Scanner(new FileReader("SO.txt"));
		while (Cfile.hasNext())
		{
			 //Letter Counts Get Reset to Zero Each Line
			 a = 0;
			 b = 0;
			 c = 0;
			 d = 0;
			 e = 0;
			 f = 0;
			 g = 0;
			 h = 0;
			 i = 0;
			 j = 0;
			 k = 0;
			 l = 0;
			 m = 0;
			 n = 0;
			 o = 0;
			 p = 0;
			 q = 0;
			 r = 0;
			 s = 0;
			 t = 0;
			 u = 0;
			 v = 0;
			 w = 0;
			 x = 0;
			 y = 0;
			 z = 0;
			 N = 0;
			temp = Cfile.nextLine();
			cosets = temp.toCharArray();
			N = cosets.length;

			for (int one=0; one<cosets.length; one++)
			{
				//Every letter increase that letters count by one
				if (cosets[one] == 'a')
					a++;
				if (cosets[one] == 'b')
					b++;
				if (cosets[one] == 'c')
					c++;
				if (cosets[one] == 'd')
					d++;
				if (cosets[one] == 'e')
					e++;
				if (cosets[one] == 'f')
					f++;
				if (cosets[one] == 'g')
					g++;
				if (cosets[one] == 'h')
					h++;
				if (cosets[one] == 'i')
					i++;
				if (cosets[one] == 'j')
					j++;
				if (cosets[one] == 'k')
					k++;
				if (cosets[one] == 'l')
					l++;
				if (cosets[one] == 'm')
					m++;
				if (cosets[one] == 'n')
					n++;
				if (cosets[one] == 'o')
					o++;
				if (cosets[one] == 'p')
					p++;
				if (cosets[one] == 'q')
					q++;
				if (cosets[one] == 'r')
					r++;
				if (cosets[one] == 's')
					s++;
				if (cosets[one] == 't')
					t++;
				if (cosets[one] == 'u')
					u++;
				if (cosets[one] == 'v')
					v++;
				if (cosets[one] == 'w')
					w++;
				if (cosets[one] == 'x')
					x++;
				if (cosets[one] == 'y')
					y++;
				if (cosets[one] == 'z')
					z++;
			}

			//Letter Frequency Values are Updated Every Line
			Va = Va+(a/N);
			Vb = Vb+(b/N);
			Vc = Vc+(c/N);
			Vd = Vd+(d/N);
			Ve = Ve+(e/N);
			Vf = Vf+(f/N);
			Vg = Vg+(g/N);
			Vh = Vh+(h/N);
			Vi = Vi+(i/N);
			Vj = Vj+(j/N);
			Vk = Vk+(k/N);
			Vl = Vl+(l/N);
			Vm = Vm+(m/N);
			Vn = Vn+(n/N);
			Vo = Vo+(o/N);
			Vp = Vp+(p/N);
			Vq = Vq+(q/N);
			Vr = Vr+(r/N);
			Vs = Vs+(s/N);
			Vt = Vt+(t/N);
			Vu = Vu+(u/N);
			Vv = Vv+(v/N);
			Vw = Vw+(w/N);
			Vx = Vx+(x/N);
			Vy = Vy+(y/N);
			Vz = Vz+(z/N);
		}

		//Averages are Figured out by Taking Summed Values and Diving It By Keyword Length
		//Which Equals the Number of Cosets
		Aa = Va/KWL;
		Ab = Vb/KWL;
		Ac = Vc/KWL;
		Ad = Vd/KWL;
		Ae = Ve/KWL;
		Af = Vf/KWL;
		Ag = Vg/KWL;
		Ah = Vh/KWL;
		Ai = Vi/KWL;
		Aj = Vj/KWL;
		Ak = Vk/KWL;
		Al = Vl/KWL;
		Am = Vm/KWL;
		An = Vn/KWL;
		Ao = Vo/KWL;
		Ap = Vp/KWL;
		Aq = Vq/KWL;
		Ar = Vr/KWL;
		As = Vs/KWL;
		At = Vt/KWL;
		Au = Vu/KWL;
		Av = Vv/KWL;
		Aw = Vw/KWL;
		Ax = Vx/KWL;
		Ay = Vy/KWL;
		Az = Vz/KWL;

		//Prints Frequencies of Text
		System.out.println("Frequencies");
		System.out.println("");
		System.out.print("A: ");
		System.out.println(Aa);
		System.out.print("B: ");
		System.out.println(Ab);
		System.out.print("C: ");
		System.out.println(Ac);
		System.out.print("D: ");
		System.out.println(Ad);
		System.out.print("E: ");
		System.out.println(Ae);
		System.out.print("F: ");
		System.out.println(Af);
		System.out.print("G: ");
		System.out.println(Ag);
		System.out.print("H: ");
		System.out.println(Ah);
		System.out.print("I: ");
		System.out.println(Ai);
		System.out.print("J: ");
		System.out.println(Aj);
		System.out.print("K: ");
		System.out.println(Ak);
		System.out.print("L: ");
		System.out.println(Al);
		System.out.print("M: ");
		System.out.println(Am);
		System.out.print("N: ");
		System.out.println(An);
		System.out.print("O: ");
		System.out.println(Ao);
		System.out.print("P: ");
		System.out.println(Ap);
		System.out.print("Q: ");
		System.out.println(Aq);
		System.out.print("R: ");
		System.out.println(Ar);
		System.out.print("S: ");
		System.out.println(As);
		System.out.print("T: ");
		System.out.println(At);
		System.out.print("U: ");
		System.out.println(Au);
		System.out.print("V: ");
		System.out.println(Av);
		System.out.print("W: ");
		System.out.println(Aw);
		System.out.print("X: ");
		System.out.println(Ax);
		System.out.print("Y: ");
		System.out.println(Ay);
		System.out.print("Z: ");
		System.out.println(Az);
		System.out.println("");
		System.out.println("");

		//Prints Frequencies of Standard English
		System.out.println("Signature of Printed English");
		System.out.println("");
		System.out.print("A: ");
		System.out.println("0.08167");
		System.out.print("B: ");
		System.out.println("0.01492");
		System.out.print("C: ");
		System.out.println("0.02782");
		System.out.print("D: ");
		System.out.println("0.04253");
		System.out.print("E: ");
		System.out.println("0.12702");
		System.out.print("F: ");
		System.out.println("0.02228");
		System.out.print("G: ");
		System.out.println("0.02015");
		System.out.print("H: ");
		System.out.println("0.06094");
		System.out.print("I: ");
		System.out.println("0.06966");
		System.out.print("J: ");
		System.out.println("0.00153");
		System.out.print("K: ");
		System.out.println("0.00772");
		System.out.print("L: ");
		System.out.println("0.04025");
		System.out.print("M: ");
		System.out.println("0.02406");
		System.out.print("N: ");
		System.out.println("0.06749");
		System.out.print("O: ");
		System.out.println("0.07507");
		System.out.print("P: ");
		System.out.println("0.01929");
		System.out.print("Q: ");
		System.out.println("0.00095");
		System.out.print("R: ");
		System.out.println("0.05987");
		System.out.print("S: ");
		System.out.println("0.06327");
		System.out.print("T: ");
		System.out.println("0.09056");
		System.out.print("U: ");
		System.out.println("0.02758");
		System.out.print("V: ");
		System.out.println("0.00978");
		System.out.print("W: ");
		System.out.println("0.02360");
		System.out.print("X: ");
		System.out.println("0.00150");
		System.out.print("Y: ");
		System.out.println("0.01974");
		System.out.print("Z: ");
		System.out.println("0.00074");
	}
}