/* who3.c - who with buffered reads
*		  - surpresses empty records 
*		  - formats time nicely
*		  - buffers input (using utmplib)
*/

#include "show.h"

#define SHOWHOST

int main()
{
	struct utmpx *utbufp,		/*holds pointer to next rec	*/
			*utmp_next();	/*returns pointer to next	*/
	if (utmp_open(UTMPX_FILE) == -1)
	{
		perror(UTMPX_FILE);
		exit(1);
	}
	while ((utbufp = utmp_next()) != ((struct utmpx *) NULL))
		show_info(utbufp);
	utmp_close();
	return 0;
}

