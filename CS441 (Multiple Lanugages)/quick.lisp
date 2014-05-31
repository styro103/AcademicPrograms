;(defun last (x)
;  (cond
;    ((null x) nil)
;	((null (cdr x)) (car x))
;	(T (last (cdr x)))
;  )
;)

; filter applies the predicate f to the
; list x and returns the list of items
; in x satisfying f
(defun filter (f x)
  (cond
    ((null x) nil)
	((funcall f (car x)) 
	   (cons (car x) (filter f (cdr x)) ))
	(T (filter f (cdr x)))
  )
)

;(cons (car x) (cdr x)) = x

(defun glue (left pivot right)
  (append left (cons pivot right)))
  
(defun sort2 (x)
  (cond
    ( (> (car x) (cadr x))
	  (cons (cadr x) (list (car x))))
	(T x)
) )

(defun quick (x)
  (cond
    ( (null x) nil)
	( (null (cdr x)) x)
	( (null (cddr x)) (sort2 x))
	(T
	  (let ((pivot (car x)))
	  (let ((left (filter #'(lambda (y) (< y pivot)) (cdr x)))
		   (right (filter #'(lambda (y) (>= y pivot)) (cdr x))))
	    (glue (quick left)
		  pivot (quick right)
		)
	  ))
	)
) )
