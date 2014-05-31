import java.awt.*;
import javax.swing.*;
import java.awt.event.*;
import java.io.*;

class MonaLisa extends JPanel
{
  Color c;
  String facetext;

  public void setColor(Color x) { c=x; }
  public void setFace(String x) { facetext=x; }

  public MonaLisa()
  {
    super();
	//setSize(100,100);
	setPreferredSize(new Dimension(300,300));
	c=Color.white;
	facetext="";
  }

  public void paintComponent(Graphics g)
  {
    g.setColor(Color.orange);
    g.fillRect(0,0, 300,300);

    //jaw
    g.setColor(Color.pink);
    g.fillOval(50,75, 200,200);

    // smile
    g.setColor(c);
    g.fillOval(75,100, 150,150);

    // face
    g.setColor(Color.pink);
    g.fillOval(50,75, 200, 125);

    // eyes
    g.setColor(Color.white);
    g.fillOval(100,90, 20,20);
    g.fillOval(180,90, 20,20);

    // pupils
    g.setColor(Color.blue);
    g.fillOval(105,95, 10,10);
    g.fillOval(185,95, 10,10);

    // face text
    g.drawString(facetext,100,150);
  }
}

class Closer extends WindowAdapter
{
  public void windowClosing(WindowEvent e)
  {
    System.out.println("Goodbye cruel world!");
	System.exit(0); // kills program
  }
}

public class gui9 extends JFrame implements ActionListener
{
  JButton [] blist;
  JTextField t;
  MonaLisa m;

  public static void main(String [] args)
  {
    JFrame w = new gui9();
	w.show();
  }

  public void actionPerformed(ActionEvent e)
  {
    for(int i=0; i<blist.length; i++)
    {
	  if(e.getSource()==blist[i])
	  {
	    switch(i){
	    	case 0: m.setColor(Color.red); break;
	    	case 1: m.setColor(Color.yellow); break;
	    	case 2: m.setColor(Color.orange); break;
	    	case 3: m.setColor(Color.black); break;
	    	default: m.setColor(Color.green);
	    }
	    t.setText("that was "+(i+1));
	    repaint();
    	}
	}
    //t.setText("Thanks for pressing the button!");

    if(e.getSource()==t) { m.setFace(t.getText()); repaint(); }
  }

  public gui9()
  {
	addWindowListener( new Closer() );
	setSize(800,640);
	setTitle("gui9 - our cooler newer exciting program!");

	m = new MonaLisa();

	JPanel kanga=new JPanel();
	kanga.add(m);

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
	t.addActionListener(this);


	Container bob = getContentPane();

	JPanel koala = new JPanel();
	koala.setLayout( new BorderLayout() );
	koala.add( new JLabel("Steve and then Just Steve!!"),
      "North");
	koala.add( bp, "South");
	//koala.add( new JLabel("To the East side"), "East");
	koala.add( kanga, "East");
	koala.add( new JLabel("West side story"), "West");
	JPanel koala2 = new JPanel();
	koala2.add( t);
	koala.add( koala2, "Center");

	bob.add(koala);

  }
}