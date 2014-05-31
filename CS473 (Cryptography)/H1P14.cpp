#include <iostream>

using namespace std;

int char2int(char x)
{
  if('a'<=x && x<='z') return x-'a';
  if('A'<=x && x<='Z') return x-'A';
  return -1;
}

char int2char(int x)
{
  return 'A'+x;
}
  
/*char decode(char x)
{
  for(int k=0; k<26; k++)
  {  
	  int y;
	  if(('a'<=x && x<='z')||('A'<=x && x<='Z'))
	  {
		y=char2int(x);
		y=(y+k)%26;
		return int2char(y);
	  }
	  else
  		return x;
  }
}*/

int main(char x)
{
  int y;
  char text[80];
  cout << "Enter your encryption please:" << endl;
  cin.getline(text,80);
  for(int k=0; k<26; k++)
  {
	  for(int i=0; i<strlen(text); i++)
	  {
		if(('a'<=x && x<='z')||('A'<=x && x<='Z'))
		{
			y=char2int(x);
			y=(y+k)%26;
		}
			text[i]=text[y];
	  }
	  cout << text << endl;
  }
  return 0;
}
