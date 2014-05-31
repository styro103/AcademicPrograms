;;; HWorld.lsp

;;; ================================================== ;;;
;;; =========== HELLO WORLD SIMULATION ============== ;;;
;;; ================================================== ;;;


;;; This function simply returns the string Hello World that is in quotes.

;Print "Hello World"
(DEFUN HELLO ()
  "HELLO WORLD"
)
 
;Adder Function
(defun adder (n) 
	(lambda (x) (+ x n))
)