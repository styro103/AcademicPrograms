/*	utmp_open.c	*/
#include 	"utmplib.h"

#define NRECS 16
#define NULLUT ((struct utmpx *)NULL)
#define UTSIZE (sizeof(struct utmpx))

static char utmpbuf[NRECS * UTSIZE];				/* storage		*/
static int num_recs;								/* num stored	*/
static int cur_rec;									/* next to go	*/
static int fd_utmp = -1;							/* read from	*/

int utmp_open(char *filename)
{
	fd_utmp = open(filename, O_RDONLY);				/* open it		*/
	cur_rec = num_recs = 0;							/* no recs yet	*/
	return fd_utmp;									/* report		*/
}
