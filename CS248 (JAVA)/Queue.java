public interface Queue
{
  public void enqueue(Object x);
  public Object dequeue();
  public Object getFront();
  public boolean isEmpty();
  public boolean isFull();
  public void makeEmpty();
}