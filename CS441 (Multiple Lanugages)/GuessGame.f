C234567
C	The Guessing Game
C	Shaun Mbateng
C	Classic Guessing Game, but in Fortran 77
      program GuessGame
	  implicit none

C -- Program Variables
	  integer numb
	  integer guess
	  integer randnumb
	  integer seed/-23434567/

	  
C -- Randomize Number
	  call random_seed(seed) 
	  numb = randnumb()
	  
C -- Function Intro
	  print *, ""
	  print *, "***Welcome to the GUESSING GAME!!***"
	  print *, "Wait...haven't we played this before?"
	  print *, "Well either way, here's a refresher."
C -- Label for goto Jump
  10  continue
C -- Input Guess
	  print *, "Pick a number between 1 and 100."
	  print *, ""
	  read *, guess
	  print *, ""
	  
C -- If Correct Guess, Display Win Message, End Program	  
	  if(guess.eq.numb) then
		print *,"You Win"
C -- If Incorrect Guess, Display Specific Message Based on Guess
	  else
		if (guess.lt.1 .or. guess.gt.100) then
			print *, "That's not even in the guessing range, idiot!"
		else
			if (guess.lt.numb) then
				print *, "Too low, dimwit!"
			else if (guess.gt.numb) then
				print *, "Too high, elbow nose!"
			end if
		end if
		
C -- Go To Where Guess is Inputted		
		goto 10
	  end if
	  end
	  
C -- Where Random Number is Generated from 1 to 100
	  FUNCTION randnumb()
      integer randnumb
      randnumb = 100+int(100*rand(0))
      RETURN
      END FUNCTION

C smbateng@thomas(11:41:04)~/Files/CS441 (Multiple Lanugages)>a.out

C ***Welcome to the GUESSING GAME!!***
C Wait...haven't we played this before?
C Well either way, here's a refresher.
C Pick a number between 1 and 100.

C 50

C Too low, dimwit!
C Pick a number between 1 and 100.

C 0

C That's not even in the guessing range, idiot!
C Pick a number between 1 and 100.

C 105

C That's not even in the guessing range, idiot!
C Pick a number between 1 and 100.

C 100

C You Win
C smbateng@thomas(11:41:32)~/Files/CS441 (Multiple Lanugages)>

	  