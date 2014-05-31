//*********************************************************
// Project 3: Two-Three Trees (Source File)
// Authors: [Shaun Mbateng and Chris Johnson]
// Date: April 10, 2013
// Class: ParaHell
// Session: Gupta - 2:25 P.M. - Monday, Wednesday
// This program impltements a 2-3 Tree Sequentially, With
//		Absorb, Discard, Insert, and Delete
//***********************************************************

#include "Nodes.h" //Include Header File

void menu(char &com); //User Menu
void insert(node * root, double i); //Insert Function
void supprimer(node * root, double d); //Delete Function (French for Delete)
void itree(node * root); //To Initialize Root
void display(node * root); //Display Tree 

int main()
{
	char command;
	double n;

	node * root = new node (NULL,NULL,NULL); //Points to Root of Tree
	itree(root);
		
	cout<<"\n"<<endl;
	cout<<"***Welcome to the Two-Three Trees Program***"<<endl;
	cout<<"***Made by Shaun Mbateng and Chris Johnson***"<<endl;
	
	do //Will Loop Till Valid Input, Calls Function Depending on Number
	{
		menu(command);

		if (command == 'Q')
			break;
		if (command == 'S')
		{
			display(root);
		}
		else
		{
			cout<<""<<endl;
			cout<<"What number would you like? (It Must be Unique if Inserting)"<<endl;
	
			do //Enter Number to Insert
			{
				cin>>n;

				if (n<MAX_NUMBER && n>0)
					break;

				cout<<""<<endl;
				cout<<"Number Must be Between 0 and "<<MAX_NUMBER<<", Enter Again"<<endl;
			} while (n >= MAX_NUMBER || n<=0); //Makes Sure Number is in Range
		
			if (command =='I')
			{
				insert(root, n);
			}
			if (command =='D')
			{
				supprimer(root, n);
			}
		}			
	} while (command != 'Q');
	
	cout<<""<<endl;
	cout<<"Bye bye."<<endl;
	cout<<""<<endl;
	
	return 0;
}

void menu(char &com) //Menu to Get User Input
{
	cout<<""<<endl;
	cout<<"What would you like to do?"<<endl;
	cout<<""<<endl;
	cout<<"Insert:   Type \"I\""<<endl;
	cout<<"Delete:   Type \"D\""<<endl;
	cout<<"Display:  Type \"S\""<<endl;
	cout<<"Quit:     Type \"Q\""<<endl;
	cout<<""<<endl;
	cin>>com;
	com = char(toupper(com));
	
	while (com != 'I' && com != 'D' && com != 'Q'  && com!= 'S')
	{
		cout<<""<<endl;
		cout<<"That isn't one of the options, pick again."<<endl;
		cin>>com;
		com = char(toupper(com));
	}
}

void insert(node * root, double i)
{
	node * walker = root; //Initialize to Root

	while (walker->lchild->lchild || walker->mchild->lchild || walker->rchild->lchild) //Loop until At Level Above Leaves
	{
		if (i<=walker->left)
			walker = walker->lchild;
		else if (i<=walker->mid)
			walker = walker->mchild;
		else
			walker = walker->rchild;
	}

	if (i == walker->left || i == walker->mid || i == walker->right) //If Number Already Exists
	{
		cout<<""<<endl;
		cout<<"Number to Insert Must be Unique"<<endl;
	}
	else
	{
		if (walker->left == NULL || walker->mid == NULL || walker->right == NULL) //If Any Open Spots in Node
		{
			if (walker->right == NULL) //Should Never Hit This Case
			{
				walker->right = i;
			}
			else if (walker->left == NULL)
				walker->left = i;
			else //If Mid is Open
			{
				if (i<walker->left) //Move Left to Mid, Insert i Into Left
				{
					double temp = walker->left;
					walker->left = i;
					walker->mid = temp;
				}
				else
				{
					walker->mid = i;
				}
			}
		}
		else //If All Spots Filled, Harder Cases Here
		{
			node * ntemp;
			
			if (walker->left>i) //Absorb Number Into Left
			{
				ntemp = new node (i,NULL,walker->left);
				supprimer(walker,walker->left);
				//cout<<"{"<<ntemp->left<<","<<ntemp->mid<<","<<ntemp->right<<"}\t{"<<walker->left<<","<<walker->mid<<","<<walker->right<<"}"<<endl;
			}
			else if (walker->mid>i) //Absorb Number Into Mid
			{
				ntemp = new node (walker->left,NULL,i);
				supprimer(walker,walker->left);
				//cout<<"{"<<ntemp->left<<","<<ntemp->mid<<","<<ntemp->right<<"}\t{"<<walker->left<<","<<walker->mid<<","<<walker->right<<"}"<<endl;
			}
			else //Absorb Number Into Right
			{
				ntemp = new node (i,NULL,walker->right);
				supprimer(walker,walker->right);
				//cout<<"{"<<ntemp->left<<","<<ntemp->mid<<","<<ntemp->right<<"}\t{"<<walker->left<<","<<walker->mid<<","<<walker->right<<"}"<<endl;
			}

			if (walker->parent->mid == NULL) //If Parent Has Only Two Children
			{
				if (walker == walker->parent->lchild) //If Walker was Left Child
				{
					if (ntemp->right<walker->left) //Make ntemp Left Child
					{
						walker->parent->mchild = walker;
						walker->parent->lchild = ntemp;
						walker->parent->left = ntemp->right;
					}
					else //Make ntemp Middle Child
					{
						walker->parent->mchild = ntemp;
						walker->parent->mid = ntemp->right;
					}
				}
				else //If Walker was Right Child
				{
					if (ntemp->right<walker->left) //Make ntemp Middle Child
					{
						walker->parent->mchild = ntemp;
						walker->parent->mid = ntemp->right;
					}
					else //Make ntemp Right Child
					{
						walker->parent->mchild = walker;
						walker->parent->rchild = ntemp;
						walker->parent->right = ntemp->right;
					}
				}
			}
			else
			{

			}

			//Update Information of ntemp
			ntemp->parent = walker->parent;
			ntemp->lchild = new node (NULL,NULL,ntemp->left);
			ntemp->mchild = new node (NULL,NULL,ntemp->mid);
			ntemp->rchild = new node (NULL,NULL,ntemp->right);
			ntemp->lchild->parent = ntemp->mchild->parent = ntemp->rchild->parent = ntemp;
		}
	}

	//Update Leaves
	walker->lchild = new node (NULL,NULL,walker->left);
	walker->mchild = new node (NULL,NULL,walker->mid);
	walker->rchild = new node (NULL,NULL,walker->right);
	walker->lchild->parent = walker->mchild->parent = walker->rchild->parent = walker;

	//Update Nodes
	while (walker->parent)
	{
		if (walker == walker->parent->lchild) //If Walker is Left Child
		{
			walker->parent->left = walker->right;
		}
		else if (walker == walker->parent->mchild) //If Walker is Mid Child
		{
			walker->parent->mid = walker->right;
		}
		else
		{
			walker->parent->right = walker->right; //If Walker is Right Child
		}

		walker = walker->parent;
	}

	//cout<<"{"<<walker->left<<","<<walker->mid<<","<<walker->right<<"}"<<endl;
}

void supprimer(node * root, double d)
{
	node * walker = root; //Initialize to Root

	while (walker->lchild->lchild || walker->mchild->lchild || walker->rchild->lchild) //Loop until At Level Above Leaves
	{
		if (d<=walker->left)
			walker = walker->lchild;
		else if (d<=walker->mid)
			walker = walker->mchild;
		else
			walker = walker->rchild;
	}

	if (d == walker->left) //If Number is Left
	{
		if (walker->left != NULL && walker->mid != NULL && walker->right != NULL) //If Node is Full
		{
			walker->left = walker->mid; //Make Left Mid
			walker->mid = NULL; //Clear Mid
		}
		else //Harder Cases Here
		{
		}
	}
	else if (d == walker->mid) //If Number is Mid
	{
		if (walker->left != NULL && walker->mid != NULL && walker->right != NULL) //If Node is Full
			walker->mid = NULL; //Clear Mid
		else //Harder Cases Here
		{
		}
	}
	else if (d == walker->right) //If Number is Right
	{
		if (walker->left != NULL && walker->mid != NULL && walker->right != NULL) //If Node is Full
		{
			walker->right = walker->mid; //Make Left Mid
			walker->mid = NULL; //Clear Mid
		}
		else //Harder Cases Here
		{
		}
	}
	else
	{
		cout<<"\nThat Number Doesn't Exist in the Tree"<<endl;
	}

	//Update Leaves
	walker->lchild = new node (NULL,NULL,walker->left);
	walker->mchild = new node (NULL,NULL,walker->mid);
	walker->rchild = new node (NULL,NULL,walker->right);
	walker->lchild->parent = walker->mchild->parent = walker->rchild->parent = walker;

	//Update Nodes
	while (walker->parent)
	{
		if (walker == walker->parent->lchild) //If Walker is Left Child
		{
			walker->parent->left = walker->right;
		}
		else if (walker == walker->parent->mchild) //If Walker is Mid Child
		{
			walker->parent->mid = walker->right;
		}
		else
		{
			walker->parent->right = walker->right; //If Walker is Right Child
		}

		walker = walker->parent;
	}
}

void itree(node * root) //Initialize Tree
{
	//Root
	root->set(17,28,MAX_NUMBER);

	//Level 2
	root->lchild = new node(3,8,root->left);
	root->mchild = new node (21,NULL,root->mid);
	root->rchild = new node(33,NULL,root->right);

	root->lchild->parent = root->mchild->parent = root->rchild->parent = root;

	//Level 3
	root->lchild->lchild = new node (1,NULL,root->lchild->left);
	root->lchild->mchild = new node (5,NULL,root->lchild->mid);
	root->lchild->rchild = new node (11,14,root->lchild->right);
	root->mchild->lchild = new node (19,NULL,root->mchild->left);
	root->mchild->mchild = new node;
	root->mchild->rchild = new node (24,NULL,root->mchild->right);
	root->rchild->lchild = new node (31,NULL,root->rchild->left);
	root->rchild->mchild = new node;
	root->rchild->rchild = new node (36,NULL,root->rchild->right);

	root->lchild->lchild->parent = root->lchild->mchild->parent = root->lchild->rchild->parent = root->lchild;
	root->mchild->lchild->parent = root->mchild->mchild->parent = root->mchild->rchild->parent = root->mchild;
	root->rchild->lchild->parent = root->rchild->mchild->parent = root->rchild->rchild->parent = root->rchild;

	//Leaves
	root->lchild->lchild->lchild = new node (NULL,NULL,root->lchild->lchild->left);
	root->lchild->lchild->mchild = new node (NULL,NULL,root->lchild->lchild->mid);
	root->lchild->lchild->rchild = new node (NULL,NULL,root->lchild->lchild->right);
	root->lchild->mchild->lchild = new node (NULL,NULL,root->lchild->mchild->left);
	root->lchild->mchild->mchild = new node (NULL,NULL,root->lchild->mchild->mid);
	root->lchild->mchild->rchild = new node (NULL,NULL,root->lchild->mchild->right);
	root->lchild->rchild->lchild = new node (NULL,NULL,root->lchild->rchild->left);
	root->lchild->rchild->mchild = new node (NULL,NULL,root->lchild->rchild->mid);
	root->lchild->rchild->rchild = new node (NULL,NULL,root->lchild->rchild->right);
	root->mchild->lchild->lchild = new node (NULL,NULL,root->mchild->lchild->left);
	root->mchild->lchild->mchild = new node (NULL,NULL,root->mchild->lchild->mid);
	root->mchild->lchild->rchild = new node (NULL,NULL,root->mchild->lchild->right);
	root->mchild->mchild->lchild = new node (NULL,NULL,root->mchild->mchild->left);
	root->mchild->mchild->mchild = new node (NULL,NULL,root->mchild->mchild->mid);
	root->mchild->mchild->rchild = new node (NULL,NULL,root->mchild->mchild->right);
	root->mchild->rchild->lchild = new node (NULL,NULL,root->mchild->rchild->left);
	root->mchild->rchild->mchild = new node (NULL,NULL,root->mchild->rchild->mid);
	root->mchild->rchild->rchild = new node (NULL,NULL,root->mchild->rchild->right);
	root->rchild->lchild->lchild = new node (NULL,NULL,root->rchild->lchild->left);
	root->rchild->lchild->mchild = new node (NULL,NULL,root->rchild->lchild->mid);
	root->rchild->lchild->rchild = new node (NULL,NULL,root->rchild->lchild->right);
	root->rchild->mchild->lchild = new node (NULL,NULL,root->rchild->mchild->left);
	root->rchild->mchild->mchild = new node (NULL,NULL,root->rchild->mchild->mid);
	root->rchild->mchild->rchild = new node (NULL,NULL,root->rchild->mchild->right);
	root->rchild->rchild->lchild = new node (NULL,NULL,root->rchild->rchild->left);
	root->rchild->rchild->mchild = new node (NULL,NULL,root->rchild->rchild->mid);
	root->rchild->rchild->rchild = new node (NULL,NULL,root->rchild->rchild->right);

	root->lchild->lchild->lchild->parent = root->lchild->lchild->mchild->parent = root->lchild->lchild->rchild->parent = root->lchild->lchild;
	root->lchild->mchild->lchild->parent = root->lchild->mchild->mchild->parent = root->lchild->mchild->rchild->parent = root->lchild->mchild;
	root->lchild->rchild->lchild->parent = root->lchild->rchild->mchild->parent = root->lchild->rchild->rchild->parent = root->lchild->rchild;
	root->mchild->lchild->lchild->parent = root->mchild->lchild->mchild->parent = root->mchild->lchild->rchild->parent = root->mchild->lchild;
	root->mchild->mchild->lchild->parent = root->mchild->mchild->mchild->parent = root->mchild->mchild->rchild->parent = root->mchild->mchild;
	root->mchild->rchild->lchild->parent = root->mchild->rchild->mchild->parent = root->mchild->rchild->rchild->parent = root->mchild->rchild;
	root->rchild->lchild->lchild->parent = root->rchild->lchild->mchild->parent = root->rchild->lchild->rchild->parent = root->rchild->lchild;
	root->rchild->mchild->lchild->parent = root->rchild->mchild->mchild->parent = root->rchild->mchild->rchild->parent = root->rchild->mchild;
	root->rchild->rchild->lchild->parent = root->rchild->rchild->mchild->parent = root->rchild->rchild->rchild->parent = root->rchild->rchild;
}

void display(node * root)
{
	node * walker = root;

	cout<<"\n---0 Means Null---\n"<<endl;

	//Dsiplay Root Level
	cout<<""<<endl;
	cout<<"Root Level: {"<<root->left<<","<<root->mid<<","<<root->right<<"}"<<endl;

	//Display Level 1
	cout<<""<<endl;
	cout<<"Level 1: ";
	cout<<"{"<<root->lchild->left<<","<<root->lchild->mid<<","<<root->lchild->right<<"} ";
	cout<<"{"<<root->mchild->left<<","<<root->mchild->mid<<","<<root->mchild->right<<"} ";
	cout<<"{"<<root->rchild->left<<","<<root->rchild->mid<<","<<root->rchild->right<<"} ";
	cout<<""<<endl;

	//Dsiplay Level 2
	cout<<""<<endl;
	cout<<"Level 2: ";
	cout<<"{"<<root->lchild->lchild->left<<","<<root->lchild->lchild->mid<<","<<root->lchild->lchild->right<<"} ";
	cout<<"{"<<root->lchild->mchild->left<<","<<root->lchild->mchild->mid<<","<<root->lchild->mchild->right<<"} ";
	cout<<"{"<<root->lchild->rchild->left<<","<<root->lchild->rchild->mid<<","<<root->lchild->rchild->right<<"} ";
	cout<<"{"<<root->mchild->lchild->left<<","<<root->mchild->lchild->mid<<","<<root->mchild->lchild->right<<"} ";
	cout<<"{"<<root->mchild->mchild->left<<","<<root->mchild->mchild->mid<<","<<root->mchild->mchild->right<<"} ";
	cout<<"{"<<root->mchild->rchild->left<<","<<root->mchild->rchild->mid<<","<<root->mchild->rchild->right<<"} ";
	cout<<"{"<<root->rchild->lchild->left<<","<<root->rchild->lchild->mid<<","<<root->rchild->lchild->right<<"} ";
	cout<<"{"<<root->rchild->mchild->left<<","<<root->rchild->mchild->mid<<","<<root->rchild->mchild->right<<"} ";
	cout<<"{"<<root->rchild->rchild->left<<","<<root->rchild->rchild->mid<<","<<root->rchild->rchild->right<<"} ";
	cout<<""<<endl;

	//Dsiplay Leaves Level
	cout<<""<<endl;
	cout<<"Leaves Level: ";
	cout<<"{"<<root->lchild->lchild->lchild->right<<"} ";
	cout<<"{"<<root->lchild->lchild->mchild->right<<"} ";
	cout<<"{"<<root->lchild->lchild->rchild->right<<"} ";
	cout<<"{"<<root->lchild->mchild->lchild->right<<"} ";
	cout<<"{"<<root->lchild->mchild->mchild->right<<"} ";
	cout<<"{"<<root->lchild->mchild->rchild->right<<"} ";
	cout<<"{"<<root->lchild->rchild->lchild->right<<"} ";
	cout<<"{"<<root->lchild->rchild->mchild->right<<"} ";
	cout<<"{"<<root->lchild->rchild->rchild->right<<"} ";
	cout<<"{"<<root->mchild->lchild->lchild->right<<"} ";
	cout<<"{"<<root->mchild->lchild->mchild->right<<"} ";
	cout<<"{"<<root->mchild->lchild->rchild->right<<"} ";
	cout<<"{"<<root->mchild->mchild->lchild->right<<"} ";
	cout<<"{"<<root->mchild->mchild->mchild->right<<"} ";
	cout<<"{"<<root->mchild->mchild->rchild->right<<"} ";
	cout<<"{"<<root->mchild->rchild->lchild->right<<"} ";
	cout<<"{"<<root->mchild->rchild->mchild->right<<"} ";
	cout<<"{"<<root->mchild->rchild->rchild->right<<"} ";
	cout<<"{"<<root->rchild->lchild->lchild->right<<"} ";
	cout<<"{"<<root->rchild->lchild->mchild->right<<"} ";
	cout<<"{"<<root->rchild->lchild->rchild->right<<"} ";
	cout<<"{"<<root->rchild->mchild->lchild->right<<"} ";
	cout<<"{"<<root->rchild->mchild->mchild->right<<"} ";
	cout<<"{"<<root->rchild->mchild->rchild->right<<"} ";
	cout<<"{"<<root->rchild->rchild->lchild->right<<"} ";
	cout<<"{"<<root->rchild->rchild->mchild->right<<"} ";
	cout<<"{"<<root->rchild->rchild->rchild->right<<"} ";
	cout<<""<<endl;
}
