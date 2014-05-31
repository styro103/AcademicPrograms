% Shaun Mbateng %
% Practice 3 %
% September 16, 2010 %

clc
clear

disp('Shaun Mbateng')
disp('Practice 3')
disp('September 16, 2010')
disp(' ')

A = [1,2;3,4]
inv(A)
b = [-1;3]
x = inv(A)*b
xAlt = A\b

disp('Problem a')
a = [6,-3,4;12,5,-7;-5,2,6]
B = [41;-26;14]
V = a\B;
x = V(1)
y = V(2)
z = V(3)

disp('Problem b')
b = [12,-5,0;-3,4,7;6,2,3]
C = [11;-3;22]
V = b\C;
x = V(1)
y = V(2)
z = V(3)

disp('Problem c')
c = [2.5,5,-2,1;18,-6.2,25,10;28,-15,-30,25;-8,12,0,-3.2]
D = [-4.06;2.897;-5.2;-4.0]
V = c\D;
x4 = V(1)
x3 = V(2)
x2 = V(3)
x1 = V(4)
