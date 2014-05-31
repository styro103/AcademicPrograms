/*	utmp_close.c	*/
#include 	"utmplib.h"


#define NRECS 16
#define NULLUT ((struct utmpx *)NULL)
#define UTSIZE (sizeof(struct utmpx))

static char utmpbuf[NRECS * UTSIZE];				/* storage		*/
static int num_recs;								/* num stored	*/
static int cur_rec;									/* next to go	*/
static int fd_utmp = -1;							/* read from	*/

void utmp_close()
{
	if( fd_utmp != -1)
		close(fd_utmp);
}

