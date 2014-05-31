import java.awt.*;
import javax.swing.*;
import java.awt.event.*;
import java.io.*;
import java.applet.Applet;

class Closer extends WindowAdapter
{
  public void windowClosing(WindowEvent e)
  {
    System.out.println("Great Game(s).");
	System.exit(0); // kills program
  }
}

public class layout extends JFrame
{
	JButton button1, button2, button3, button4, button5, button6;
	JButton button7, button8, button9;
	JLabel label1, label2, label3, label4, label5, label6, label7;
	JLabel label8, label9, label10, label11, label12, label13;
	JLabel label14, label15, label16;

	public layout()
	{
		setLayout(new GridLayout(5,5));

		button1 = new JButton("1");
		add(button1);

		label1 = new JLabel("");
		add(label1);

		button2 = new JButton("2");
		add(button2);

		label2 = new JLabel("");
		add(label2);

		button3 = new JButton("3");
		add(button3);

		label3 = new JLabel("");
		add(label3);

		label4 = new JLabel("");
		add(label4);

		label5 = new JLabel("");
		add(label5);

		label6 = new JLabel("");
		add(label6);

		label7 = new JLabel("");
		add(label7);

		button4 = new JButton("4");
		add(button4);

		label8 = new JLabel("");
		add(label8);

		button5 = new JButton("5");
		add(button5);

		label9 = new JLabel("");
		add(label9);

		button6 = new JButton("6");
		add(button6);

		label10 = new JLabel("");
		add(label10);

		label11 = new JLabel("");
		add(label11);

		label12 = new JLabel("");
		add(label12);

		label13 = new JLabel("");
		add(label13);

		label14 = new JLabel("");
		add(label14);

		button7 = new JButton("7");
		add(button7);

		label15 = new JLabel("");
		add(label15);

		button8 = new JButton("8");
		add(button8);

		label16 = new JLabel("");
		add(label16);

		button9 = new JButton("9");
		add(button9);

	}

	public static void main(String args[])
	{
		JFrame w = new layout();
		w.setTitle("Layout");
		w.addWindowListener( new Closer() );
		w.setSize(600,600);
		w.show();
	}

}

