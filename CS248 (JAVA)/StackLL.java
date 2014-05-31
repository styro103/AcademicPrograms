public class StackLL implements Stack
{
  private class node
  {
    public Object data;
	public node next;
  }
  
  node top;
  int count;

  
  public StackLL()
  {
	makeEmpty();
  }

  public void push(Object x) 
  {
    node nn = new node();
	nn.next = top;
	top = nn;
	top.data = x;
	count++;
  }
  public Object pop() 
  {
    if(isEmpty()) return null;
	Object toreturn = getTop();
	top = top.next;
	count--;
	return toreturn;
  }
  public Object getTop() { return isEmpty()?null:top.data; }
  public boolean isEmpty() { return top==null; }
  public boolean isFull() { return false; }
  public void makeEmpty() { top = null; count=0; }
  public int size() { return count; }
}