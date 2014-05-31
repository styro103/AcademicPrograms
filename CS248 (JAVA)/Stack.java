public interface Stack
{
	public void push(Object x);
	public Object pop();
	public Object getTop();
	public boolean isEmpty();
	public boolean isFull();
	public void makeEmpty();
}