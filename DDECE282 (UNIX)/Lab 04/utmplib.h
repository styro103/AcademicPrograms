#ifndef 	UTMPLIB_H
#define 	UTMPLIB_H
#include	<stdio.h>
#include	<sys/types.h>
#include	<utmpx.h>
#include	<fcntl.h>
#include	<time.h>
int utmp_open(char *filename ); 
struct utmpx *utmp_next();
int utmp_reload();
void utmp_close(); 
#endif
