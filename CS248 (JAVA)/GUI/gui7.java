import java.awt.*;
import javax.swing.*;
import java.awt.event.*;
import java.io.*;

class Closer extends WindowAdapter
{
  public void windowClosing(WindowEvent e)
  {
    System.out.println("Goodbye cruel world!");
	System.exit(0); // kills program
  }
}

public class gui7 extends JFrame implements ActionListener
{
  JButton [] blist;
  JTextField t;

  public static void main(String [] args)
  {
    JFrame w = new gui7();
	w.show();
  }
  
  public void actionPerformed(ActionEvent e)
  {
    for(int i=0; i<blist.length; i++)
	{
	  if(e.getSource()==blist[i])
	    t.setText("that was "+(i+1));
	}
    //t.setText("Thanks for pressing the button!");
  }
  
  public gui7()
  {
	addWindowListener( new Closer() );
	setSize(600,400);
	setTitle("gui7 - our cooler newer exciting program!");

	blist = new JButton[5];
	for(int i=0; i<5; i++)
	{
	  blist[i]=new JButton("Button #"+(i+1));
	  blist[i].addActionListener(this);
	}

	JPanel bp = new JPanel();
	bp.setLayout( new BorderLayout() );
	bp.add( blist[0], "North");
	bp.add( blist[1], "South");
	bp.add( blist[2], "East");
	bp.add( blist[3], "West");
	bp.add( blist[4], "Center");

	t=new JTextField("Push a button");


	Container bob = getContentPane();

	JPanel koala = new JPanel();
	koala.setLayout( new BorderLayout() );
	koala.add( new JLabel("Steve and then Just Steve!!"),
      "North");
	koala.add( bp, "South");
	koala.add( new JLabel("To the East side"), "East");
	koala.add( new JLabel("West side story"), "West");
	JPanel koala2 = new JPanel();
	koala2.add( t);
	koala.add( koala2, "Center");

	bob.add(koala);

  }
}