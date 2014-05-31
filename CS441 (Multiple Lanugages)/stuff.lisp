
(defun fact (n)
  (if (< (print n) 2)
    1
    (* n (fact (- n 1)))
  )
)

(fact 20)
(print (car (cons 1 2)))
(print (cdr (cons 1 2)))

;(append '(1 2) '(3 4)) -> (1 2 3 4)
(defun append2 (x y)
  (cond
    ((null x) y) ; if x is empty, y
	(T (cons (car x) (append2 (cdr x) y)))
  )
)

; a function that makes a function
(defun addx (x)
  (lambda (y) (+ x y))
)

(defun doubler (f)
  (lambda (x) (funcall f (funcall f x)))
)

(defun curry (f x)
  (lambda (y)
    (funcall f x y))
)
