//Chen 
//Date March 1st 2010
//Review for test 2


#include <iostream.h>

int one(int , int &);
int two(int &, int ); 
int something();

int main()
{
  int x=9, y=18;
  int z;
  
  z=one(x,y); //y:19
  cout<<two(x, y)<<endl;
  cout<<x<<endl;
  cout<<y<<endl;
  cout<<z<<endl;
   
  return 0;
 }
 
 int one (int a, int & b)
 {
   a=a+b%3;
   cout<<++b<<endl;
   return something();
 
 }
 
 int two(int &x, int y)
 {
    x=x+y++;
	return something()+y;
 }
 
 int something()
 {
   cout<<" doh "<<endl;
   return 42;
 }
