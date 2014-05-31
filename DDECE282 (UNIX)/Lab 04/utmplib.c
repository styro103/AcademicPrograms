/* utmplib.c	*/
#include	<stdio.h>
#include	<sys/types.h>
#include	<utmpx.h>
#include	<utmplibx.h>
#include	<fcntl.h>
#include	<time.h>

#define NRECS 16
#define NULLUT ((struct utmpx *)NULL)
#define UTSIZE (sizeof(struct utmpx))

static char utmpbuf[NRECS * UTSIZE];				/* storage		*/
static int num_recs;								/* num stored	*/
static int cut_rec;									/* next to go	*/
static int fd_utmp = -1;							/* read from	*/

utmp_open(char *filename)
{
	fd_utmp = open(filename, O_RDONLY);				/* open it		*/
	cur_rec = num_recs = 0;							/* no recs yet	*/
	return fd_utmp;									/* report		*/
}

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

int utmp_reload()
{
	int amt_read;
	amt_read = read(fd_utmp, utmpbuf, NRECS * UTSIZE);
	num_recs = amt_read/UTSIZE;
	cur_rec = 0;
	return num_recs;
}

utmp_close()
{
	if( fd_utmp != -1)
		close(fd_utmp);
}