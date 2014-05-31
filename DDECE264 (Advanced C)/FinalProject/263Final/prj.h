#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#ifndef _PROJ_
#define _PROJ_

#define MAX_COLUMNS 5
#define MAX_LINE_NUMBER 20
#define MAX_MISS_COUNT 5

#define RANDOM_COLUMN

struct word 
{
	int columnNo;//which column to display
	int lineNo;	//which line to display
	int priority;	//priority
	char text[10];	//the text
	struct word		*nextWord;//points to another word
};

#endif
