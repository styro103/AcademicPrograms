//*********************************************************
// Project 5 -- Jailhouse Rock/Connect Four
// Author: [Shaun Mbateng]
//Date: March 24, 2010
//Session: Chen - 11:00 A.M. - Monday, Wednesday, Friday
//This program is a game of connect four.
//***********************************************************

#include <iostream.h>
#include <fstream.h>
#include <stdlib.h>
#include <time.h>

void win();
void stop();
int p;
int pl;
int level;

void drawboard(ostream &, char [6][7], int, int);
void humanmove();
void horizontalwin();
void verticalwin();
void diagonalwin();
void Randommove();
void AImove(); //not completed
void Spockmove(); //not completed
char board [6][7]={0};
int column;
int rows;
bool used [6][7];
char player;
bool playing = true;

ofstream outfile;

int main ()
{		
		cout<<""<<endl;
		cout<<""<<endl;
		cout<<"**Welcome to the Connect Four Program**"<<endl;
		cout<<""<<endl;
		void nop();
		nop();
		humanmove();
		win();
		
	return 0;
}

void drawboard(ostream & out, char b[][7], int r, int c) 
{
	out << endl;
	for (int x = r-1; x >= 0; x--) {
		out << "|";
		for (int y = 0; y < c-1; y++)
			out << "----";
		out << "---|" << endl << "|";
		for (int y = 0; y < c-1; y++)
			if (b[x][y] == 0)
				out << "   |";
			else
				out << " " << b[x][y] << " |";
		if (b[x][c-1] == 0)
			out << "   |" << endl;
		else
			out << " " << b[x][c-1] << " |" << endl;
	}
	
	out << "|";
	for (int y = 0; y < c-1; y++)
		out << "----";
	out << "---|" << endl << endl;
} 

void nop()
{
	cout<<"How many human players? (1 or 2) ";
	while (p<1 || p>2)
	{
		cin>>p;
		if (p==1)
		{
			cout<<"Human vs. Computer"<<endl;
		}
		else if (p==2)
		{
			cout<<"Human vs. Human"<<endl;
		}
		else if (p==0)
		{
			cout<<"You can't have computer vs. computer, pick again. ";
		}
		else if (p>2)
		{
			cout<<"You can't have that many players, pick again. ";
		}
		else
		{
			cout<<"That won't work. Pick again. ";
		}
		cout<<"This is being played on a 6x7 board."<<endl;
		cout<<""<<endl;
	}
	if (p==1)
	{
		cout<<"What level do you want to play?"<<endl;
		cout<<"1: Random (Easy)"<<endl;
		cout<<"2: AI (Medium)"<<endl;
		cout<<"3: Spock (Hard)"<<endl;
		cout<<"0: Return to Player Selection"<<endl;
		cin>>level;
		if (level==0)
		{
			p=0;
			return nop();
		}
		else if (level<0 || level>3)
		{
			cout<<"That's not a level, pick again."<<endl;
			cin>>level;
		}
	}
}
void humanmove()
{	
	outfile.open("gamelog01.txt");
	
	column=0;
	rows = 0;
	pl=1;

	if (p==2)
	{
		while (playing==true)
		{	
			if(pl==1)
				cout<<"What column would player 1 like to play? (0 to quit) "<<endl;
			else if (pl==-1)
				cout<<"What column would player 2 like to play? (0 to quit) "<<endl;
			cin>>column;
			if (column==0)
			{
				cout<<""<<endl;
				if (pl==1)
				{
					cout<<"Player 1 quits, player 2 wins."<<endl;
					outfile<<"Player 1 quits, player 2 wins."<<endl;
				}
				else if (pl==-1)
				{
					cout<<"Player 2 quits, player 1 wins."<<endl;
					outfile<<"Player 2 quits, player 1 wins."<<endl;
				}
				cout<<""<<endl;
				break;
			}
			while(column<0 || column>7)
			{
				cout<<"Sorry, that column is invalid. Choose a column from 1-7 ";
				cin>>column;
			}
			if (pl==1)
			{
				player = 'X';
			}
			else if (pl==-1)
			{
				player = 'O';
			}
			
			while((used[rows][column-1] == true) && (rows<=7))
			{
				rows++;
			}
				
			if(rows>=6)
			{
				cout<<"Sorry, that column is full. Try again ";
			}
			else
			{	
				board[rows][column-1] = player;
				used[rows][column-1] = true;
				if(pl==1)
				{
					outfile<<"Player 1 plays in column "<<column<<"."<<endl;
				}
				else
				{
					outfile<<"Player 2 plays in column "<<column<<"."<<endl;
				}
				pl*=-1;
			}
			verticalwin();
			horizontalwin();
			diagonalwin();
			rows = 0;
			drawboard(cout, board,6,7);
		}
		drawboard(cout, board,6,7);
		drawboard(outfile, board,6,7);
	}
	else if (p==1)
	{
		int order;
		srand(time(NULL));
		order=1+rand()%5;
		if (order==1 || order==3 || order==5)
		{
			pl=1;
		}
		else if (order==2 || order==4)
		{
			pl=-1;
			Randommove();
		}
		while (playing)
		{	
			if(pl==1)
			{
				cout<<"What column would player 1 like to play? (0 to quit) "<<endl;
				cin>>column;
			}
			if (column==0)
			{
				cout<<""<<endl;
				cout<<"Player one quits, computer wins."<<endl;
				outfile<<"Player one quits, computer wins."<<endl;
				cout<<""<<endl;
				break;
			}
			while(column < 0 || column > 7)
			{
					cout<<"Sorry, that column is invalid. Choose a column from 1-7 ";
					cin>>column;
			}
			if (pl==1)
			{
				player = 'X';
			}
			else if (pl==-1)
			{
				if (level==2)
				{
					AImove();
				}
				else if (level==1)
				{
					Randommove();
				}
			}
			while((used[rows][column-1] == true) && (rows<=7))
			{
				rows++;
			}
					
			if(rows>=6)
			{
				cout<<"Sorry, that column is full. Try again ";
			}
			else
			{	
				board[rows][column-1] = player;
				used[rows][column-1] = true;
				if(pl==1)
				{
					outfile<<"Player 1 plays in column "<<column<<"."<<endl;
				}
				else
				{
					outfile<<"Computer plays in column "<<column<<"."<<endl;
				}
				pl*=-1;
			}
			verticalwin();
			horizontalwin();
			diagonalwin();
			rows = 0;
			drawboard(cout, board,6,7);
		}
		drawboard(cout, board,6,7);
		drawboard(outfile, board,6,7);
	}
}

void horizontalwin()
{
	//Player One Win Check
	if (board[rows][column-1]=='X'
		and board[rows][column-2]=='X'
		and board[rows][column-3]=='X'
		and board[rows][column-4]=='X')
	{
		stop();
	}
	if (board[rows][column-1]=='X'
		and board[rows][column-2]=='X'
		and board[rows][column]=='X'
		and board[rows][column+1]=='X')
	{
		stop();
	}
	if (board[rows][column-1]=='X'
		and board[rows][column-2]=='X'
		and board[rows][column-3]=='X'
		and board[rows][column]=='X')
	{
		stop();
	}
	//Player Two Win Check
	if (board[rows][column-1]=='O'
		and board[rows][column-2]=='O'
		and board[rows][column-3]=='O'
		and board[rows][column-4]=='O')
	{
		stop();
	}
	if (board[rows][column-1]=='O'
		and board[rows][column-2]=='O'
		and board[rows][column]=='O'
		and board[rows][column+1]=='O')
	{
		stop();
	}
	if (board[rows][column-1]=='O'
		and board[rows][column-2]=='O'
		and board[rows][column-3]=='O'
		and board[rows][column]=='O')
	{
		stop();
	}
}

void verticalwin()
{
		//Player One Win Check
		if (board[rows][column-1]=='X'
			and board[rows-1][column-1]=='X'
			and board[rows-2][column-1]=='X'
			and board[rows-3][column-1]=='X')
		{
			stop();
		}
		//Player Two Win Check
		if (board[rows][column-1]=='O'
			and board[rows-1][column-1]=='O'
			and board[rows-2][column-1]=='O'
			and board[rows-3][column-1]=='O')
		{
			stop();
		}
}

void diagonalwin() //not completed
{
	//Player One Win Check
	if (board[rows][column-1]=='X'
		and board[rows-1][column-2]=='X'
		and board[rows-2][column-3]=='X'
		and board[rows-3][column-4]=='X')
	{
		stop();
	}
	if (board[rows][column-1]=='X'
		and board[rows-1][column-2]=='X'
		and board[rows+1][column]=='X'
		and board[rows+1][column+1]=='X')
	{
		stop();
	}
	if (board[rows][column-1]=='X'
		and board[rows-1][column-2]=='X'
		and board[rows-2][column-3]=='X'
		and board[rows+1][column]=='X')
	{
		stop();
	}
	if (board[rows][column-1]=='X'
		and board[rows-1][column]=='X'
		and board[rows-2][column+1]=='X'
		and board[rows-3][column+2]=='X')
	{
		stop();
	}
	if (board[rows][column-1]=='X'
		and board[rows+1][column-2]=='X'
		and board[rows+2][column-3]=='X'
		and board[rows-1][column]=='X')
	{
		stop();
	}
	if (board[rows][column-1]=='X'
		and board[rows-1][column]=='X'
		and board[rows-2][column+1]=='X'
		and board[rows+1][column-2]=='X')
	{
		stop();
	}
	//Player Two Win Check
		if (board[rows][column-1]=='O'
		and board[rows-1][column-2]=='O'
		and board[rows-2][column-3]=='O'
		and board[rows-3][column-4]=='O')
	{
		stop();
	}
	if (board[rows][column-1]=='O'
		and board[rows-1][column-2]=='O'
		and board[rows+1][column]=='O'
		and board[rows+1][column+1]=='O')
	{
		stop();
	}
	if (board[rows][column-1]=='O'
		and board[rows-1][column-2]=='O'
		and board[rows-2][column-3]=='O'
		and board[rows+1][column]=='O')
	{
		stop();
	}
	if (board[rows][column-1]=='O'
		and board[rows-1][column]=='O'
		and board[rows-2][column+1]=='O'
		and board[rows-3][column+2]=='O')
	{
		stop();
	}
	if (board[rows][column-1]=='O'
		and board[rows+1][column-2]=='O'
		and board[rows+2][column-3]=='O'
		and board[rows-1][column]=='O')
	{
		stop();
	}
	if (board[rows][column-1]=='O'
		and board[rows-1][column]=='O'
		and board[rows-2][column+1]=='O'
		and board[rows+1][column-2]=='O')
	{
		stop();
	}
}

void AImove() //not completed
{
	if (board[rows][column-1]=='X'
		and board[rows-1][column-1]=='X'
		and board[rows-2][column-1]=='X')
	{
		column=column-1;
	}
	else if (board[rows][column-1]=='O'
		and board[rows-1][column-1]=='O'
		and board[rows-2][column-1]=='O')
	{
		column=column-1;
	}
	else
	{
		srand(time(NULL));
		column=1+rand()%7;
	}
	player = 'O';
}

void win()
{	
	if (column==0)
		stop();
	else
	{
		pl=pl*-1;
		cout<<"Game over!"<<endl;
		if (p==1)
		{
			if (pl==1)
			{
				cout<<"Player one wins!"<<endl;
				outfile<<"Player one wins!"<<endl;
						
			}
			else if (pl==-1)
			{
				cout<<"Computer beats human."<<endl;
				outfile<<"Computer beats human."<<endl;
			}
		}
		if (p==2)
		{
			if (pl==1)
			{
				cout<<"Player one wins!"<<endl;
				outfile<<"Player one wins!"<<endl;
			}
			else if (pl==-1)
			{
				cout<<"Player two wins!"<<endl;
				outfile<<"Player two wins!"<<endl;
			}
		}
	}
	outfile.close();
}

void stop()
{
	playing=false;
}

void Randommove()
{
	srand(time(NULL));
	column=1+rand()%7;
	player = 'O';
}

void Spockmove() //not completed
{

}
