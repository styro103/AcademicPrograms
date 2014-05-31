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

public class gui4 extends JFrame
{
  public static void main(String [] args)
  {
    JFrame w = new gui4();
	w.addWindowListener( new Closer() );
	w.setSize(600,400);
	w.setTitle("gui4 - our cooler newer exciting program!");

	Container bob = w.getContentPane();
	
	JPanel koala = new JPanel();
	koala.setLayout( new BorderLayout() );
	koala.add( new JLabel("Steve and then Just Steve!!"),
      "North");
	koala.add( new JLabel("what else"), "South");
	koala.add( new JLabel("To the East side"), "East");
	koala.add( new JLabel("West side story"), "West");
	JPanel koala2 = new JPanel();
	koala2.add( new JLabel("A Picture"));
	koala.add( koala2, "Center");
	
	bob.add(koala);

	w.show();
  }
}