//Chen 
//Date March 29nd 2010
//Examples on file I/O


#include <iostream.h>
#include <fstream.h>

const int MAX=80;

int main()
{
   ofstream outfile("March31Out.txt");
 
   outfile<<"Go Bulldogs!\n";
   outfile<<"Final Four!\n";
   outfile<<"CS142, Computer Science"<<endl;
		 
   outfile.close();
   
   //read data from a file
   
   const int MAX=80;
   char buffer[MAX];
   
   ifstream infile;
   infile.open("March31Out.txt");
   
   cout<<endl;
   
   while(infile)
   {
      infile.getline(buffer, MAX);  //read a line of text
	  cout<<buffer<<endl;           // display it
	}
	cout<<endl;
	infile.close();
  return 0;
 }
 
 
