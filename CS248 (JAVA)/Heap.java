import java.io.*;
import java.util.*;

public class Heap implements PQ
{
  Comparable [] H;
  int last;
  
  public Heap(int size)
  {
    H = new Comparable[size+1];
	makeEmpty();
  }
  
  private int parent(int pos) { return pos/2; }
  private int leftchild(int pos) { return 2*pos; }
  private int rightchild(int pos) { return 2*pos+1; }
  
  public void enqueue(Comparable x)
  {
    if(isFull()) return;
    H[++last]=x;
	bubbleup(last);
  }
  
  private void bubbleup(int pos)
  {
    if(pos==1) return;
	if(H[parent(pos)].compareTo(H[pos])<=0) return;
	swap(H,parent(pos),pos);
	bubbleup(parent(pos));
  }
  
  private static void swap(Comparable [] A, int x, int y)
  {
    Comparable temp=A[x];
	A[x]=A[y];
	A[y]=temp;
  }
  
  public Comparable dequeue() // deleteMin
  {
    if(isEmpty()) return null;
	Comparable min = getFront();
	H[1]=H[last--];
	bubbledown(1);
	return min;
  }
  
  private void bubbledown(int pos)
  {
    if(leftchild(pos)>last) return; // no children!
	// find smallest child
	int smallest=leftchild(pos);
	if(rightchild(pos)<=last) // right child exists
	{
	  if(H[smallest+1].compareTo(H[smallest])<0)
	     smallest=smallest+1;
	}
	// see if we're larger than smallest child
	if(H[pos].compareTo(H[smallest])>0)
	{
	  swap(H,pos,smallest);
	  bubbledown(smallest);
	}
  }
  
  public Comparable getFront() { return H[1]; }
  public boolean isEmpty() { return last==0; }
  public boolean isFull() { return last>=H.length-1; }
  public void makeEmpty() { last=0; }

  public static void main(String [] args) throws IOException
  {
    Scanner fishfile = new Scanner(new FileReader("fishfile.txt"));
	int numfish = fishfile.nextInt();
	PQ pile = new Heap(100);
	for(int i=0; i<numfish; i++)
	  pile.enqueue(new Fish(fishfile));
	while(!pile.isEmpty())
	  System.out.println(pile.dequeue());
  }
  
  
}