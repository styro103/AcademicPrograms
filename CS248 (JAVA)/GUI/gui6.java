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

class buttonListener implements ActionListener
{
  JTextField t;

  public buttonListener(JTextField f)
  { t=f; }

  public void actionPerformed(ActionEvent e)
  {
    t.setText("Thanks for pressing the button!");
  }
}

public class gui6 extends JFrame
{
  public static void main(String [] args)
  {
    JFrame w = new gui6();
	w.addWindowListener( new Closer() );
	w.setSize(600,400);
	w.setTitle("gui6 - our cooler newer exciting program!");

	JButton [] blist = new JButton[5];
	for(int i=0; i<5; i++)
	  blist[i]=new JButton("Button #"+(i+1));

	JPanel bp = new JPanel();
	bp.setLayout( new BorderLayout() );
	bp.add( blist[0], "North");
	bp.add( blist[1], "South");
	bp.add( blist[2], "East");
	bp.add( blist[3], "West");
	bp.add( blist[4], "Center");

	JTextField t=new JTextField("Push a button");
	blist[3].addActionListener(new buttonListener(t));


	Container bob = w.getContentPane();

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

	w.show();
  }
}