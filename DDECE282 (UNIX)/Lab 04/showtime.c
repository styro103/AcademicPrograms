#include "show.h"
#define SHOWHOST

void showtime(long timeval)
{
	char *cp;
	cp = ctime(&timeval);
	printf("%12.12s", cp+4);
}
