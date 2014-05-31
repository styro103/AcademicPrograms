//**************************************
// Name: word shooter
// Description:It pops out all the words from a dynamically created string.It signals the user when nop more words remain to be popped out.
// By: Nidhin George Olikara
//
// Inputs:Just input a string/sentence of any length.
//
// Returns:character pointer to base address of the input string/sentence.
//
// Assumes:Just try it out!
//
// Side Effects:None observed(yet!)
Mail me any bugs/better algorithms to olikara@indiatimes.com
//
//This code is copyrighted and has// limited warranties.Please see http://www.Planet-Source-Code.com/vb/scripts/ShowCode.asp?txtCodeId=1319&lngWId=3//for details.//**************************************

#include <stdio.h>
int flag=0,n=0,cnt=0;
void take(char *q)
{
	int ii;
	static int i=0;/*static int declared*/
	if (flag==0)/*flag set low for 1st word*/
	{
	n++;
if (cnt==1)/*situation when only one word in string*/
{
	while (*(q+i)!='\n')
	{	printf("%c",*(q+i));
	i++;
	}
	return;
}
while(*(q+i)!=' ')
{
	
	flag=1;
	printf("%c",*(q+i));
	i++;
}
	}
else
	{
		n++;
	if (n==cnt)/*This takes care of last word as last word ends in an EOS and not in a tab/space*/
	{
		while (*(q+i)!='\n')
		{
			printf("%c",*(q+i));
			i++;
			
		}
		return;
	}
		if (*(q+i)==' ' && *(q+i+1)!=' ')/*Any word can be identified by a space and non-space char occuring simultaneously*/
		{
			i++;
			while (*(q+i)!=' ')
			{
			printf("%c",*(q+i));
			i++;
			}
				
		}
	}
}
main()
{
int i=0,nm=0;
char *ch,cc;
printf("Please enter any string/sentence\n");
while (1)/*This loop scans in string dynamically*/
{
	scanf("%c",ch+i);
	if (*(ch + i)=='\n')
	{
		break;
	}
	i++;
}
for (i=0;*(ch+i)!='\n';i++)
{
	if (*(ch+i)==' ' && *(ch+i+1)!=' ')
cnt++;/*counter for number of words read in*/
}
cnt++;
fflush(stdin);
printf("Do you wish to pop out a word...?(y/n)\n");
scanf("%c",&cc);
while (cc=='y')
{
	nm++;
	if (nm>cnt)
	{
printf("Sorry, no more words to pop out!...\n");
break;
	}
take(ch);
printf("Do you wish to pop out a word...?(y/n)\n");
fflush(stdin);
scanf("%c",&cc);
}

}