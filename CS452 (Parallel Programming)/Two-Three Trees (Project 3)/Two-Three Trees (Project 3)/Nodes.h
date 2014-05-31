//*********************************************************
// Project 3: Two-Three Trees (Header File)
// Authors: [Shaun Mbateng and Chris Johnson]
// Date: April 10, 2013
// Class: ParaHell
// Session: Gupta - 2:25 P.M. - Monday, Wednesday
// This Part Holds the Libraries that the .cpp File Needs, and
//		Defines the Node Structure, and Maximum Number
//***********************************************************
#include <stdio.h>
#include <stdlib.h>
#include <iostream>

using namespace std;

#define MAX_NUMBER 100

class node
{
	public:
		node * parent; //Points to Parent
		node * lchild; //Left Child
		node * mchild; //Middle Child
		node * rchild; //Right Child
		
		double left; //Left Element
		double mid; //Middle Element
		double right; //Right Element

		node(double l = NULL, double m = NULL, double r = NULL) //Create New Node
		{
			left = l;
			mid = m;
			right = r;
			lchild = mchild = rchild = parent = NULL;
		}

		void set(double a,double b,double c) //Edit Node
		{
			left = a;
			mid = b;
			right = c;
			lchild = mchild = rchild = parent = NULL;
		}
};

