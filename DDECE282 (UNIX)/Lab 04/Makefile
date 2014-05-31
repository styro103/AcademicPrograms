#Shaun Mbateng
#Lab 4

cc=gcc

who3: who3.o show utmplib
	$(cc) who3.o -L. -lshow -lutmplib -o who3
show: show.h showtime.o show_info.o
	ar r libshow.a show_info.o showtime.o	
utmplib: utmp_open.o utmp_reload.o utmp_close.o utmp_next.o 
	ar r libutmplib.a utmp_open.o utmp_reload.o utmp_close.o utmp_next.o

who3.o: who3.c
	$(cc) -c who3.c
utmp_close.o: utmp_close.c utmplib.h
	$(cc) -c utmp_close.c
utmp_open.o: utmp_open.c utmplib.h
	$(cc) -c utmp_open.c
utmp_next.o: utmp_next.c utmplib.h
	$(cc) -c utmp_next.c
utmp_reload.o: utmp_reload.c utmplib.h
	$(cc) -c utmp_reload.c
show_info.o: show_info.c show.h
	$(cc) -c show_info.c
showtime.o: showtime.c show.h
	$(cc) -c showtime.c
lib:
	make libutmplib
	make libshow
clean:
	rm -f *.o
cleanall:
	rm -f *.o
	rm -f *.a
	rm who3
