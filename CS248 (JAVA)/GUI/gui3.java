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

public class gui3 extends JFrame
{
  public static void main(String [] args)
  {
    JFrame w = new gui3();
	w.addWindowListener( new Closer() );
	w.setSize(300,300);
	w.setTitle("gui3 - our cooler newer exciting program!");

	Container bob = w.getContentPane();
	bob.add( new JLabel("Steve and then Just Steve!!") );

	w.show();
  }
}