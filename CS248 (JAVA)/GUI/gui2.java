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

public class gui2 extends JFrame
{
  public static void main(String [] args)
  {
    JFrame w = new gui2();
	w.addWindowListener( new Closer() );
	w.setTitle("gui2 - our cooler newer exciting program!");
	w.show();
  }
}