#include<stdio.h>
#include<stdlib.h>
struct node
{
	int a;
	struct node *ptr; //struct node *next; might be more meaningful
};
int main()
{
	struct node *head;
	struct node *newnode;
	struct node *walker;
	char ans;
	head=(struct node*)malloc(sizeof(struct node));
	head->a=1;
	head->ptr=NULL;
	printf("The node's value is %d\n",head->a);
	walker=head;
	while(1)
	{
		printf("Do you want a new node?\n");
		scanf("%c",&ans);
		fflush(stdin);
		if(ans=='N')
			break;
		newnode=(struct node*)malloc(sizeof(struct node));
		printf("Please enter the value\n");
		scanf("%d",&newnode->a);
		fflush(stdin);
		walker->ptr=newnode;
		walker=walker->ptr;
		newnode->ptr=NULL;
		printf("The new node is %d\n", newnode->a);
	}
	walker=head;
	while(walker!=NULL)
	{
		printf("%d\n",walker->a);
		walker=walker->ptr;
	}

	walker=head;
	while(walker!=NULL)
	{
		walker=head->ptr;
		free(head);
		head=walker;
		
	}

}
