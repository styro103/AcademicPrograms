//Name Program
//Shaun Mbateng
//CS-142 Test #3 No. 6 (10 Points)

#include <iostream.h>
#include <fstream.h>

int main()
{
	char fname[20];
	char lname[20];
	int age;
	
	ofstream outfile("exam3.txt");
	
	cout<<"What is you first and last name?"<<endl;
	cin>>fname;
	cin>>lname;
	cout<<""<<endl;
	cout<<"How old are you?"<<endl;
	cin>>age;
	
	outfile<<"Name: "<<fname<<" ";
	outfile<<lname<<"   ";
	outfile<<"Age: "<<age<<endl;
	
	outfile.close();
	
	return 0;
}

