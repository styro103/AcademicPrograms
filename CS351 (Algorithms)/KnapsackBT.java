import java.util.*;

public class KnapsackBacktrack
{
	private double maxValue;
    private double K;
    private double [ ] s;
    private double [ ] v;
    private List bestList;           //members of solution set for current best value
    private int numItems;          //number of items in set to select from (first item is dummy 0)

    public KnapsackBacktrack(double capacity, double [ ] size, double [ ] value, int num)
    {
    	maxValue = 0.0;
        K = capacity;
        s = size;
        v = value;
        numItems = num;
        bestList = null;
    }

    private void knapsack(int index, double currentSize, double currentValue, List cList)
    {
    	if (currentSize <= K && currentValue > maxValue)
    	{
        	maxValue = currentValue;
            bestList = new LinkedL:ist(cList);
        }

       	if (promising(index, currentSize, currentValue)
       	{
        	List  leftList  = new LinkedList(cList);
            leftList.add(new Integer(index + 1) );
            knapsack(index + 1, currentSize + s[index+1], currentValue+v[index+1], leftList);
          	rightList = new LinkedList(cList);
            knapsack(index + 1, currentSize, currentValue, rightList);
         }

    }

    private boolean promising(int item, double size, double value)
    {
    	double bound = value;
        double totalSize = size;
        int k = item + 1;

        if (size > K)  return false;

       	while (k < numItems && totalSize + s[k] <= K)
       	{
        	bound += v[k];
            totalSize += s[k];
            k++;
        }

        if (k < numItems)
        	bound += (K - totalSize) * (v[k]/s[k]);
        return bound > maxValue;
	}

    public void findSolution( )
    {
    	List currentList = new LinkedList( );   //create an empty list
        knapsack (0, 0.0, 0.0, currentList);
        System.out.print("The solution set is:  ");
        for (int i = 0; i < bestList.size( ); i++)
        {
     		System.out.print("  " + bestList.get(i) );
        	System.out.println( );
        	System.out.println("The value contained in the knapsack is:  $"+maxValue);
        }
     }
}

