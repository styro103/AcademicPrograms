import java.io.*;
import java.util.*;

public class postfix
{
  static boolean isop(String x)
  {
    if(x.charAt(0)=='+') return true;
    if(x.charAt(0)=='-') return true;
    if(x.charAt(0)=='*') return true;
    if(x.charAt(0)=='/') return true;
    return false;
  }

  static String doop(String a, String b, String op)
  {
    int x= Integer.parseInt(a);
    int y= Integer.parseInt(b);

    if(op.charAt(0)=='+') return ""+(x+y);
    if(op.charAt(0)=='-') return ""+(x-y);
    if(op.charAt(0)=='*') return ""+(x*y);
    if(op.charAt(0)=='/') return ""+(x/y);

    return "error";
  }

  public static void main(String [] args)
  {
    Stack S = new StackArray(100);

    Scanner kbd = new Scanner(System.in);

    while(kbd.hasNext())
    {
      String token=kbd.next();
      if(isop(token))
      {
        String b=(String) S.pop();
        String a=(String) S.pop();
        String result = doop(a,b,token);
        S.push(result);
      }
      else
        S.push(token);
    }
    System.out.println(S.pop());
  }
}
