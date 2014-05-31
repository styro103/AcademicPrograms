#ifndef 	SHOW_H
#define 	SHOW_H
#include	<stdio.h>
#include	<sys/types.h>
#include	<utmpx.h>
#include	<fcntl.h>
#include	<time.h>
void showtime(long timeval); 
void show_info (struct utmpx *utbufp );
#endif


