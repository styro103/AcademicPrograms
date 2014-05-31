/*
	Shaun Mbateng
	CS 431 - Theory of Operating Systems
	December 15, 2013
*/
#include<iostream>
#include<fstream>
#include<string>
#include <stdlib.h>
#include<time.h>
#include<list>

using namespace std;

string type;
int RCount;
int WCount;
int n;

class Page
{
	public:
	bool dirty;
	unsigned int address;
	bool used;

	Page()
	{
		dirty = false; 
		address = 0; 
		used = false;
	}
	Page(unsigned int x, char m)
	{
		address = x;
		
		if(m == 'W') 
			dirty = true; 
		used = true;
	}
	void addAddress(unsigned int x, char m)
	{
		address=x;
		
		if(m == 'W') 
			dirty = true;
	}

};

class Cache
{
	public:
	Page * cache;
	int size;

	Cache()
	{
		cache = new Page[1024]; 
		size = 0;
	}
	Cache(int n)
	{
		size = n; 
		cache = new Page[size]; 
		
		for(int i = 0; i<size-1; i++)
		{
			cache[i] = Page();
		} 
	}

	bool isFull()
	{
		for(int i = 0; i<size; i++)
		{
			if(cache[i].used == false) 
				return false;
		} 
		return true;
	}

	void add(Page p)
	{
		for(int i = 0; i<size; i++)
		{
			if(cache[i].used == false)
				cache[i] = p;
		}
	}

	private:
	void remove(int num)
	{
		if(cache[num].dirty == true)
		{
			cache[num].dirty = false; 
			WCount++;
		} 
		cache[num] = Page();
	}

	void replace(unsigned int x, char m)
	{
		srand(time(0));
		RCount++;
		
		if(type == "Rand")
		{
			int num = rand()%(n);
			remove(num);
			Page temp = Page(x,m);
			cache[num] = temp;
		}
		
		if(type == "LRU")
		{
			remove(0); 
			Page temp = Page(x,m); 
			update(0); 
			cache[size-1] = temp;
		}
		
		if(type == "FIFO")
		{
			remove(0); 
			Page temp = Page(x,m); 
			update(0);
			cache[size-1] = temp;
		}
	}

	void update(int i)
	{
		Page temp = Page(); 
		temp.dirty = cache[i].dirty; 
		temp.address = cache[i].address;
		
		for(int loc = i; loc<size-1; loc++)
		{
			cache[loc] = cache[loc+1];
		}
		
		cache[size-1] = temp;
	}

	public:
	void check(unsigned int x, char m)
	{
		int isIn = 0;
		int loc = 0;
		
		for(int i = 0; i<size; i++)
		{
			if(cache[i].address == x)
			{
				isIn=1; 
				loc=i; 
				
				if(m == 'W')
				{
					cache[i].dirty = true;
				}
			}
		}
		
		if(isIn == 1)
		{
			if(type == "LRU")
			{
				update(loc);
			}
		}

		if(isIn == 0)
		{
			replace(x, m);
		}
	}
};



int main(int argc, char** argv)
{
	RCount = 0;
	WCount = 0;
	Cache C;
	int count = 0;

	n = 3;
	C = Cache(n);

    type = "FIFO";

	char * filename;
	filename = new char[1024];
	filename = "Test.Traces";
	unsigned int address;
	char mode;
	FILE * file = fopen(filename, "r");

	unsigned int temp1;
	unsigned int temp2;

	if ( file != NULL ) 
	{
		while( fscanf(file, "%x %c", &address, &mode) != EOF) 
		{
			cout<<"count: "<<count<<endl;
			unsigned int tempadd = address/4096;
	
			if(C.isFull()==false)
			{
				Page temp=Page(tempadd, mode); 
				C.add(temp);
			}
			else
			{
				C.check(tempadd, mode);
			}
			
			count++;
		}
	}
	
	cout<<"Total Memory Frames: "<<n<<endl;
	cout<<"Events in Trace: "<<count<<endl;
	cout<<"Total Disk Reads: "<<RCount<<endl;
	cout<<"Total Disk Writes: "<<WCount<<endl;
	
	return 0;
}
