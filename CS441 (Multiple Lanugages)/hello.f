C234567
      program hello
      implicit none
      integer x,z
      real y
C all variable declarations at the top only
      print *,"hello class!"
      print *,"Fortran is fun!"
      do 10 x=1,20
C random numbers - rand(0) returns a real from 0..1
        z=1+int(100*rand(0))
        print *,z
        print *,"in a loop ",x
  10  continue
      if(x.ge.5) print*,"yep"
      if(x.lt.100) then
        print *,"one"
      else
        print *,"two"
      endif
C this is a comment
      read *,x
      end
      
