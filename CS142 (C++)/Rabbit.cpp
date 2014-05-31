//*******************************************************************
// Project 2--Alice in Chains...Land
// Author: [Shaun Mbateng]
//Date: January 25, 2010 
//Session ????
//This programs asks the crazy rabbit how many minutes he is late,
// then tells him and his client(s) how many hours, minutes, and seconds that 
// he is late.
//*******************************************************************

#include <iostream.h>

//Mr. Rabbit
int main()
{
	double l,h,m,s;
	
	//Mr. Rabbit
	cout<<""<<endl;
	cout<<"How many minutes are you late Mr. Rabbit? ";
	cin>>l;
	
	h=int(l/60);
	m=int(((l/60.0)-h)*60);
	s=int(((((l/60)-h)*60)-m)*60);
	
	cout<<"Mr. Rabbit, you are "<<h<<" hour(s), "<<m<<" minute(s), and "<<s<<" second(s) late."<<endl;
	cout<<"I will tell your client(s)."<<endl;
	cout<<""<<endl;
	cout<<""<<endl;

//Clients
	cout<<"Mr. Rabbit is "<<h<<" hour(s), "<<m<<" minute(s), and "<<s<<" second(s) late."<<endl;

//If Statements
if (h<1)
	cout<<"He is on his way. Deal!"<<endl;
	
else if (h>=1  
	and h<2)
		cout<<"He had a personal problem involving his pants, and will arrive shortly."<<endl;
else if (h>=2 
	and	h<5)
		cout<<"Mr. Rabbit is not the rabbit you are looking for."<<endl;
else if (h>=5 
	and h<10)
		cout<<"Honestly dude, you've been totally stood up. Loser!"<<endl;
else if (h>=10 
	and h<20)
		cout<<"He's ''sick'', man. He's like totally ''sick''. Droopy ears and everything."<<endl;
	
else
	cout<<"Wait, you actually waited that long for the crazy rabbit? HAHAHAHAHAHA!!!!!"<<endl;
	
	return 0;
}
