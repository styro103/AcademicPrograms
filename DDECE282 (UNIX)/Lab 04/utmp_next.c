/*	utmp_next.c	*/
#include 	"utmplib.h"

#define NRECS 16
#define NULLUT ((struct utmpx *)NULL)
#define UTSIZE (sizeof(struct utmpx))

static char utmpbuf[NRECS * UTSIZE];				/* storage		*/
static int num_recs;								/* num stored	*/
static int cur_rec;									/* next to go	*/
static int fd_utmp = -1;							/* read from	*/

struct utmpx *utmp_next()
{
	struct utmpx *recp;								/* error ?		*/
	if (fd_utmp == -1)
		return NULLUT;
	if (cur_rec == num_recs && utmp_reload() == 0)	/* any more?	*/
		return NULLUT;
		/* get address of next record	*/
	recp = (struct utmpx *) &utmpbuf[cur_rec * UTSIZE];
	cur_rec++;
	return recp;
}
