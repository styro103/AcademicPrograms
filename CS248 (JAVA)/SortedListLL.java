import java.io.*;

public class SortedListLL implements SortedList
{
  private class node
  {
    Comparable item;
	node next;
  }
  node head;
  int count;
  
  public SortedListLL()
  {
    makeEmpty();
  }
  public void makeEmpty()
  {
    head=null; count=0;
  }
  
  public void insert(Comparable x)
  { head=insertrec(head,x); }
  
  private node insertrec(node cabeza, Comparable x)
  {
    if(cabeza==null)
	{
	  node nn=new node();
	  nn.item=x; nn.next=null;
	  count++;
	  return nn;
	}
	if(x.compareTo(cabeza.item)<=0) // insert at front
	{
	  node nn=new node();
	  nn.item=x; nn.next=cabeza;
	  count++;
	  return nn;
	}
	cabeza.next=insertrec(cabeza.next,x);
	return cabeza;
  }
  
  public void delete(Comparable x) {}
  public void delete(int pos) {}
  
  public Comparable get(int pos)
    { return getrec(head,pos); }
  
  private Comparable getrec(node tete, int pos)
  {
    if(tete==null) return null;
	if(pos==0) return tete.item;
	return getrec(tete.next,pos-1);
  }
  
  public int size() { return count; }
}