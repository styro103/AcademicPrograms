public class StackArray implements Stack
{
	Object [] pile;
	int top;
	
	public StackArray(int size)
	{
		pile = new Object[size];
		top = -1;
	}
	
	public void push(Object x) {if (!isFull()) pile[++top]=x;}
	public Object pop() {return isEmpty()?null:pile[top--];}
	public Object getTop() {return isEmpty()?null:pile[top];}
	public boolean isEmpty() {return top<0;}
	public boolean isFull() {return pile.length<=top+1;}
	public void makeEmpty() {top=-1;}
	public int size() {return top+1;}
}