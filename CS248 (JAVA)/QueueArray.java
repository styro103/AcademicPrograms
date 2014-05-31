public class QueueArray implements Queue
{
  Object [] donut;
  int front, back, count;
  
  public QueueArray(int size)
  {
    donut = new Object[size];
	makeEmpty();
  }

  public void enqueue(Object x)
  {
    if(isFull()) return;
	back++; if(back>=donut.length) back=0;
	donut[back]=x;
	count++;
  }
  public Object dequeue()
  {
    if(isEmpty()) return null;
	Object item=getFront();
	front++; if(front>=donut.length) front=0;
	// front = (front>=donut.length) ? 0 : front+1;
	count--;
	return item;
  }
  public Object getFront() { return isEmpty()?null:donut[front]; }
  public boolean isEmpty() { return count<=0; }
  public boolean isFull() { return count>=donut.length; }
  public void makeEmpty() { front=0; back=-1; count=0; }
  public int size() { return count; }
}