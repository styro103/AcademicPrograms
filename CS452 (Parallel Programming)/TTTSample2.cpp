struct TreeNode
{
	int Sdata,Ldata;
	TreeNode *Parent,*Left,*Mid,*Right;
};
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
class Two_Three_Tree{
private:
	TreeNode *root;
public:
	Two_Three_Tree()
	{
		TreeNode s;
		s.Sdata=-1;
		s.Ldata=-1;
		root=new TreeNode;
		root=NULL;
		s.Parent=NULL;
		s.Left=NULL;
		s.Mid=NULL;
		s.Right=NULL;

	}
	~Two_Three_Tree();
	bool IsEmpty()
	{
	if(root==NULL)
		return true;
	return false;
	}
	
	bool is_Two_Node(TreeNode *N)
	{
	if(N->Sdata!=-1 && N->Ldata!=-1 && N->Left==NULL && N->Right==NULL)
		return true;
	return false;
	}
	bool is_three_Node(TreeNode *N)
	{
	if(N->Ldata!=-1 && N->Sdata!=-1 && N->Left==NULL && N->Right==NULL && N->Mid==NULL)
		return true;
	return false;
	}
	TreeNode * Search_leaf(int a)
	{
	TreeNode *temp=root;
	while(temp!=NULL)
	{
		if(a<temp->Sdata)
			temp=temp->Left;
		else if(a<temp->Sdata&&a>temp->Ldata)
			temp=temp->Mid;
		else
			temp=temp->Right;
	}
	return temp;
	}

};


