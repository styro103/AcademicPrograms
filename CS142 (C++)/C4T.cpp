//*********************************************************
// Project 5 -- Jailhouse Rock/Connect Four
// Author: [Shaun Mbateng]
//Date: March 24, 2010
//Session: Chen - 11:00 A.M. - Monday, Wednesday, Friday
//This program is a game of connect fout.
//***********************************************************

#include <iostream.h>
#include <fstream.h>

// This program is written by Ankur Gupta.
// This program is a template for the Connect Four game.

// This function draws the board.
void drawboard(ostream &, char [][7], int, int);

int main () 
{
	int col;
	ofstream outfile;
	outfile.open("gamelog01.txt");
	
	char board [6][7] = {0};
	
	// Remove lines 18-21 (the block of code below)
	// when you write your program.
	col=0;
	while (col<=7)
	{
		cout<<"What column do you want to play?"<<endl;
		cin>>col;
		for (int x = 0; x < 6; x++)
			for (int y = 0; y < 7; y++)
				board[x][y] = '-';
		board[0][col-1] = 'X';
		
		// WRITE YOUR MENU PART HERE!!!
		
		// This is a sample use of the drawboard function.
		// It prints out the board to the screen.
		drawboard(cout, board,6,7);
		
		outfile.close();
	}
	return 0;
}

// This function prints the board to the indicated ostream object.
// The values in the board are 'X' for player 1, 'O' (the letter) for player 2, and 
// the ASCII value of 0 (zero) for an empty space.
void drawboard(ostream & out, char b[][7], int r, int c) 
{
	out << endl;
	for (int x = r-1; x >= 0; x--) {
		for (int y = 0; y < c; y++)
			if (b[x][y] == 0)
				out << "  ";
			else
				out << b[x][y] << " ";
		out << endl;
	}
	out << endl << endl;
} // end drawboard function
