#include "show.h"
#define SHOWHOST

void show_info(struct utmpx *utbufp)
{
	if (utbufp->ut_type != USER_PROCESS)
		return;
	printf("%-8.8s", utbufp->ut_name);
	printf(" ");
	printf("%-8.8s", utbufp->ut_line);
	printf(" ");
	showtime(utbufp->ut_xtime);
#ifdef SHOWHOST
	if (utbufp->ut_host[0] != '\0')
		printf(" (%s)", utbufp->ut_host);
#endif
	printf("\n");
}

	