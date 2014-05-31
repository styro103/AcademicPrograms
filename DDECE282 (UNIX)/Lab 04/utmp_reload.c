/*	utmp_reload.c	*/
#include 	"utmplib.h"

#define NRECS 16
#define NULLUT ((struct utmpx *)NULL)
#define UTSIZE (sizeof(struct utmpx))

static char utmpbuf[NRECS * UTSIZE];				/* storage		*/
static int num_recs;								/* num stored	*/
static int cur_rec;									/* next to go	*/
static int fd_utmp = -1;							/* read from	*/

int utmp_reload()
{
	int amt_read;
	amt_read = read(fd_utmp, utmpbuf, NRECS * UTSIZE);
	num_recs = amt_read/UTSIZE;
	cur_rec = 0;
	return num_recs;
}
