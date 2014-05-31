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
  

char encode(char x)
{
  int y;
  if(('a'<=x && x<='z')||('A'<=x && x<='Z'))
  {
    y=char2int(x);
    y=(y+3)%26;
    return int2char(y);
  }
  else
    return x;
}

char decode(char x)
{
  int y;
  if(('a'<=x && x<='z')||('A'<=x && x<='Z'))
  {
    y=char2int(x);
    y=(y+23)%26;
    return int2char(y);
  }
  else
    return x;
}

int main()
{
  char text[80];
  cout << "Enter your plaintext please:" << endl;
  cin.getline(text,80);

  for(int i=0; i<strlen(text); i++)
    text[i]=encode(text[i]);

  cout << text << endl;

  for(int i=0; i<strlen(text); i++)
    text[i]=decode(text[i]);

  cout << text << endl;
  return 0;
}
