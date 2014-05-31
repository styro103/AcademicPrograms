public class QueueLL implements Queue
{
  private class node
  {
    public Object data;
	public node next;
  }
  node front, back;
  int count;

  public QueueLL()
  {
	makeEmpty();
  }

  public void enqueue(Object x)
  {
    node nn = new node();
	nn.data = x; nn.next=null;
	if(isEmpty())
	  front=nn;
	else
	  back.next=nn;
	back=nn;
	count++;
  }
  public Object dequeue()
  {
    if(isEmpty()) return null;
	Object item=getFront();
	front=front.next;
	if(front==null) back=null;
	count--;
	return item;
  }
  public Object getFront() { return isEmpty()?null:front.data; }
  public boolean isEmpty() { return count<=0; }
  public boolean isFull() { return false; }
  public void makeEmpty() { front=back=null; count=0; }
  public int size() { return count; }
}