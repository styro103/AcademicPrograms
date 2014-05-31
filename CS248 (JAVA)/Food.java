public class Food
{
  double flavor;
  int calories;
  
  public Food(double f, int c) { flavor=f; calories=c; }
  public String toString() { return ""+flavor+" "+calories; }
  
  public double getFlavor() { return flavor; }
  public int getCalories() { return calories; }
  
  public void stale() { flavor=flavor/2; }
}