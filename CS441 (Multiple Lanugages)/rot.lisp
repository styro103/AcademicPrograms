
;rotate once
(defun rot (x)
  (cond
    ( (null x) nil) ;no items
	( (null (cdr x)) x) ;one item
	(T
      (append (cdr x) (list (car x)))	
	)
  )
)

(defun build (x y z)
  (cond
    ((null x) z)
	(T
	  (build (cdr x) (rot y)
	    (cons y z)
	  )
	)
  )
)
