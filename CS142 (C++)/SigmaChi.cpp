//*******************************************************************
// Program--Sigma Chi
// Author: [Shaun Mbateng]
//Date: March 24, 2010 
//This program asks the person what information about Sigma Chi
// that they want to know (that the program says it will give) and 
// shows it to them.
//*******************************************************************

#include <iostream.h>

void Standard();
void Creed();
void Spirit();
void Song();
void Founders();
void Motto();

int main()
{
	int selection;
	char Y='y';
	
	do{
	cout<<""<<endl;
	cout<<"**Welcome to The Sigma Chi Public Information Program**"<<endl;
	cout<<""<<endl;
	cout<<"What information would you like to know? "<<endl;
	cout<<"Here are you possible selections."<<endl;
	cout<<"1. The Jordan Standard"<<endl;
	cout<<"2. The Sigma Chi Creed"<<endl;
	cout<<"3. The Spirit of Sigma Chi"<<endl;
	cout<<"4. The Founding of Sigma Chi"<<endl;
	cout<<"5. The Sigma Chi Sweetheart Song"<<endl;
	cout<<"6. Nomenclature and Insignia"<<endl;
	cout<<"7. The Seven Founders"<<endl;
	cout<<"8. The Public Motto"<<endl;
	cout<<""<<endl;
	cout<<"Make a number selection. ";
	cin>>selection;
	cout<<""<<endl;
  
//If/While Statements/Display
if (selection==1)
{
	Standard();
}

else if (selection==2)
{
	Creed();
}

else if (selection==3)
{
	Spirit();
}

else if (selection==5)
{
	Song();
}

else if (selection==7)
{
	Founders();
}

else if (selection==8)
{
	Motto();
}

else if (selection<1 || selection>8)
{
	cout<<"Sorry, but that is not one of the choices. "<<endl;
	cout<<""<<endl;
}

	cout<<"All of the information was taken from The Norman Shield "<<endl;
	cout<<"	(Reference Manual to the Sigma Chi Fraternity) "<<endl;
	cout<<""<<endl;
	cout<<"Would you like to make another selection? (y/n) "<<endl;
	cin>>Y;
	cout<<""<<endl;
 } while (Y=='y');

	return 0;
}

void Standard()
{
	cout<<"              The Jordan Standard "<<endl;
	cout<<"The confidence of the Founders of Sigma Chi was based upon "<<endl; 
	cout<<"a belief that the principles which they professed and the ideal "<<endl; 
	cout<<"of the Fraternity which they sought were but imperfectly "<<endl; 
	cout<<"realized in the organizations by which they were surrounded. "<<endl;
	cout<<""<<endl;
	cout<<"The standard with which the fraternity started was declared "<<endl; 
	cout<<"by Isaac M. Jordan to be that of admitting no man to "<<endl; 
	cout<<"membership in Sigma Chi who is not believed to be: "<<endl;
	cout<<""<<endl;
	cout<<"A Man of Good Character....... "<<endl;
	cout<<"A Student of Fair Ability......."<<endl;
	cout<<"With Ambitious Purposes......."<<endl;
	cout<<"A Congenial Disposition......."<<endl;
	cout<<"Possessed of Good Morals......."<<endl;
	cout<<"Having a High Sense of Honor and"<<endl;
	cout<<"A Deep Sense of Personal Responsibility. "<<endl;
	cout<<""<<endl;
}

void Creed()
{
	cout<<"            The Sigma Chi Creed "<<endl;
	cout<<"I believe in fairness, decency and good manners. "<<endl; 
	cout<<"I will endeavor to retain the spirit of youth. "<<endl; 
	cout<<"I will try to make my college, the Sigma Chi Fraternity, and "<<endl;
	cout<<"my own chapter more honored by all men and women and "<<endl; 
	cout<<"more beloved and honestly respected by our own brothers. "<<endl; 
	cout<<"I say these words in all sincerity; "<<endl; 
	cout<<"That Sigma Chi has given me favor and distinction; "<<endl; 
	cout<<"that the bond of our fellowship is reciprocal, "<<endl; 
	cout<<"that I will endeavor to so build myself and "<<endl; 
	cout<<"so conduct myself that I will ever be a credit to our Fraternity. "<<endl;
	cout<<""<<endl;
}

void Spirit()
{
	cout<<"         The Spirit of Sigma Chi "<<endl;
	cout<<"The Spirit of Sigma Chi, as conceived by the Founders "<<endl;
	cout<<"more than 150 years ago yet visible and alive today, "<<endl; 
	cout<<"is based on the theory that... "<<endl;
	cout<<""<<endl;
	cout<<"	...Friendship among members, sharing a common belief in an ideal,... "<<endl;
	cout<<"	...and possessing different temperaments, talents, and convictions... "<<endl;
	cout<<"	...is superior to friendship among members having the same temperaments, "; 
	cout<<"		talents, and convictions; and that... "<<endl;
	cout<<"	...Genuine friendship can be maintained without surrendering the "<<endl;
	cout<<"		principle of individuality or sacrificing one's "<<endl; 
	cout<<"		personal judgment. "<<endl;
	cout<<""<<endl;
}

void Song()
{
	cout<<"         The Sigma Chi Sweetheart Song "<<endl;
	cout<<"When the world goes wrong, as it's bound to do"<<endl;
	cout<<"And you've broken Dan Cupid's bow. And you long for the girl you used to love,"<<endl;
	cout<<"the maid of the long ago."<<endl;
	cout<<"Why light your pipe, bid sorrow avaunt,"<<endl;
	cout<<"Blow the smoke from your alter of dreams "<<endl;
	cout<<"And wreathe the face of your dream-girl there"<<endl; 
	cout<<"The love that is just what it seems."<<endl;
	cout<<""<<endl;
	cout<<"The girl of my dreams is the sweetest girl"<<endl; 
	cout<<"Of all the girls I know Each sweet co-ed,"<<endl; 
	cout<<"like a rainbow trail Fades in the after glow"<<endl;
	cout<<"The blue of her eyes and the gold of her hair"<<endl; 
	cout<<"Are a blend of the western sky"<<endl;
	cout<<"And the moonlight beams On the girl of my dreams"<<endl; 
	cout<<"She's the Sweetheart of Sigma Chi."<<endl;
	cout<<""<<endl;
	cout<<"The girl of my dreams is the sweetest girl Of all the girls I know"<<endl; 
	cout<<"Our sweet romance Like a timeless dance Dwells in my heart and soul"<<endl;
	cout<<"The love in her eyes and the warmth of her smile Endure as the years go by"<<endl;
	cout<<"And the moon still beams On the girl of my dreams"<<endl;
	cout<<"Like a bright shining star in the sky My sweetheart of Sigma Chi."<<endl;
	cout<<""<<endl;
}

void Founders()
{
	cout<<"			The Seven Founders "<<endl;
	cout<<"Benjamin Piatt Runkle (September 3, 1836 – June 28, 1916) Courage"<<endl;
	cout<<"Thomas Cowan Bell (May 14, 1832 - February 3, 1919) Wisdom"<<endl;
	cout<<"William Lewis Lockwood (October 31, 1836 - August 17, 1867) Integrity"<<endl;
	cout<<"Isaac M. Jordan (May 5, 1835 - December 3, 1890) High Ambition"<<endl;
	cout<<"Daniel William Cooper (September 2, 1830 - December 11, 1920) Self-Control"<<endl;
	cout<<"Franklin Howard Scobey (May 27, 1837 - July 22, 1888) Courtesy"<<endl;
	cout<<"James Parks Caldwell (March 27, 1841 - April 5, 1912) Fidelity"<<endl;
}

void Motto()
{
	cout<<"			The Public Motto "<<endl;
	cout<<"In Hoc Signo Vinces "<<endl;
	cout<<"Meaning: In This Sign You Will Conquer."<<endl;
	cout<<""<<endl;
}
