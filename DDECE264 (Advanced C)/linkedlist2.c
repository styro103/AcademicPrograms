#include<stdio.h>
#include<stdlib.h>
struct node
{
	int a;
	struct node *next; //You may have any name for this pointer
};
int main()
{
	struct node *head;
	struct node *newnode;
	struct node *walker;
	char ans;
	head=(struct node*)malloc(sizeof(struct node));
	head->a=1;
	head->next=NULL;
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
		walker->next=newnode;
		walker=walker->next;
		newnode->next=NULL;
		printf("The new node is %d\n", newnode->a);
	}
	//Add a new node to the beginning
	newnode=(struct node*)malloc(sizeof(struct node));
	printf("Please enter the node to be the new head:\n");
	scanf("%d",&newnode->a);
	newnode->next=head;
	head=newnode;
	putchar('\n');

	//Add a new node to the end
	newnode=(struct node*)malloc(sizeof(struct node));
	printf("Please enter the node to be the tail\n");
	scanf("%d",&newnode->a);

	walker=head;
	while(walker->next!=NULL)
	{
		walker=walker->next;
	}
	walker->next=newnode;
	newnode->next=NULL;
	putchar('\n');

	//Display the entire list
	walker=head;
	while(walker!=NULL)
	{
		printf("%d\n",walker->a);
		walker=walker->next;
	}

	//Free the entire list
	walker=head;
	while(walker!=NULL)
	{
		walker=head->next;
		free(head);
		head=walker;
		
	}

}
