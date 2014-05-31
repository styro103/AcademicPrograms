; Shaun Mbateng
; CS 441 - J. Sorenson
; This LISP Program Takes a Number, and Prints All
; 	Primes Up to It
	
(defun isPrime (n x) ;Checks if Number is Prime
	(cond
		((< x 2) T) ;If x < 2
		(T ;If x >= 2
			(cond
				((= (rem n x) 0) nil) ;If Divides Evenly, False
				(T ;Else
					(isPrime n (- x 1)) ;Decrement x, Recall Function
				)
			)
		)
	)
)

(defun LP (n)
	(cond
		((< n 2) nil) ;n < 2, Return Empty List, Don't Recursive Call
		((= n 2) (list n)) ;n = 2, Add 2 to List, End Recursive Calling
		(T ;n > 2
			(append
					(LP (- n 1)) ;Recursive Call Previous Number, Get List from 2 to n-1
					(if (isPrime n (isqrt n)) ;Check if Prime, Pass n and sqrt(n)
						(list n) ; ;If True Insert Number
					)
			)
		)
	)
)

;Sample Run
; * (load "Primes.lisp")

; T
; * (LP 3)

; (2 3)
; * (LP 4)

; (2 3)
; * (LP 5)

; (2 3 5)
; * (LP 100)

; (2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97)
; * (LP 1)

; NIL
; *
