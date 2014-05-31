public interface PQ
{
  public void enqueue(Comparable x);
  public Comparable dequeue();
  public Comparable getFront();
  public boolean isEmpty();
  public boolean isFull();
  public void makeEmpty();
}