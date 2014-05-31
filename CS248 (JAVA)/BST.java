import java.io.*;
import java.util.*;

public class BST
{
  private class treenode
  {
    Comparable item;
	treenode left, right;
  }
  treenode root;
  Queue Q;

  public BST() { root=null; Q=new QueueLL(); }

  public void insert(Comparable x)
    { root=insert(root,x); }

  // returns the root of the subtree after insertion
  private treenode insert(treenode r, Comparable x)
  {
    if(r==null) // base case
	{
	  treenode n=new treenode();
	  n.item=x; n.left=n.right=null;
	  return n;
	}
	// recursive case
	if(x.compareTo(r.item)<0) // x is smaller
	{
	  r.left=insert(r.left,x);
	  return r;
	}
	// x is larger (or equal)
	r.right=insert(r.right,x);
	return r;
  }

  private boolean deleteresult;

  public boolean delete(Comparable x)
  {
    deleteresult=false;
	root=delete(root,x);
	return deleteresult;
  }

  private treenode delete(treenode r, Comparable x)
  {
	if(r==null) return r;
	// recursive cases next
	if(x.compareTo(r.item)<0)
	{
	  r.left=delete(r.left,x);
	  return r;
	}
	if(x.compareTo(r.item)>0)
	{
	  r.right=delete(r.right,x);
	  return r;
	}
	// found a match - base case

	// 0 child case
	if(r.left==null && r.right==null)
	{
	  deleteresult=true;
	  return null;
	}
	// 1 child case - left child only
	if(r.right==null)
	{
	  deleteresult=true;
	  return r.left;
	}
	// 1 child case - right child only
	if(r.left==null)
	{
	  deleteresult=true;
	  return r.right;
	}
	// 2 children
	Comparable is = findsmallest(r.right);
	r.item = is;
	r.right=delete(r.right,is);
	return r;
  }

  private Comparable findsmallest(treenode r)
  {
    if(r==null) return null; // should never happen
	if(r.left==null) return r.item;
	return findsmallest(r.left);
  }

  // returns null if not found
  public Comparable lookup(Comparable x)
    { return lookup(root,x); }

  private Comparable lookup(treenode r, Comparable x)
  {
    if(r==null) return null;
	int compareResult = x.compareTo(r.item);
	if(compareResult==0) return r.item;
	if(compareResult<0)
	  return lookup(r.left,x);
	return lookup(r.right,x);
  }

  public void print()
  { print(root); }

  private void print(treenode r)
  {
    if(r==null) return;
	print(r.left);
	System.out.println(r.item);
	print(r.right);
  }

  // iterator methods - traversals

  public static final int PREORDER=0;
  public static final int INORDER=1;
  public static final int POSTORDER=2;

  public void reset(int order)
  {
    if(order<PREORDER || order>POSTORDER)
	  order=INORDER;
    Q.makeEmpty();
	traversal(root,order);
  }

  private void traversal(treenode r,int order)
  {
    if(r==null) return;
	if(order==PREORDER) Q.enqueue(r.item);
	traversal(r.left,order);
	if(order==INORDER) Q.enqueue(r.item);
	traversal(r.right,order);
	if(order==POSTORDER) Q.enqueue(r.item);
  }

  public boolean hasNext() { return !Q.isEmpty(); }
  public Comparable getNext()
    { return (Comparable) Q.dequeue(); }


  public static void main(String [] args) throws IOException
  {
    Scanner FishFile = new Scanner(new FileReader("FishFile.txt"));
	int numfish = FishFile.nextInt();
	BST tree = new BST();
	for(int i=0; i<numfish; i++)
	  tree.insert(new Fish(FishFile));

	System.out.println("Preorder:");
	tree.reset(BST.PREORDER);
	while(tree.hasNext())
	  System.out.println(tree.getNext());

	System.out.println("Inorder:");
	tree.reset(BST.INORDER);
	while(tree.hasNext())
	  System.out.println(tree.getNext());

	System.out.println("Postorder:");
	tree.reset(BST.POSTORDER);
	while(tree.hasNext())
	  System.out.println(tree.getNext());

	// Shark attack on everyone
	tree.reset(0);
	while(tree.hasNext())
	  ((Fish)tree.getNext()).sharkAttack();



	Fish tokill = new Fish("","","",5);
	tree.delete(tokill);

	System.out.println("Preorder:");
	tree.reset(BST.PREORDER);
	while(tree.hasNext())
	  System.out.println(tree.getNext());

  }
}