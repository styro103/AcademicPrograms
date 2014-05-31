public interface SortedList
{
  public void insert(Comparable x);
  public void delete(Comparable x);
  public void delete(int pos);
  public Comparable get(int pos);
  public int size();
}