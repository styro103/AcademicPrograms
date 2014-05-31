(defun additem (x taco)
  (mapcar 
    #'(lambda (y) (cons x y)) 
	taco)
)

; This one is broken.
(defun powerset (x)
  (cond
    ((null x) '(()) ) ; empty set
	((null (car x)) '(()) )
	(T 
	  (let (ps (powerset (cdr x)))
	    (append ps (additem (car x) ps))
	  )
	)
  )
)

; OK this one works.  See why??
(defun power (x)
  (cond ((null x) '(()) )
        (T (append (power (cdr x))
		           (additem (car x)
				     (power (cdr x))
				   )
			)
		)
  )
)
