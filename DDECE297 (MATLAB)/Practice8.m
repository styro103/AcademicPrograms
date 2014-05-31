% Shaun Mbateng %
% Practice 8 %
% November 11, 2010 %

clc
clear

disp('Shaun Mbateng')
disp('Practice 8')
disp('November 11, 2010')
disp(' ')

a = 2
b = 2
c = 4
d = -4
x = 7

A = x<2*c
B = a~=b
C = x+b>c
D = abs(d)>=c | d<b-c
E = ~(x<10) & (x>=6)
F = ~((x==2) | (x>5))
G = x~=b*2 | b>=1 & d>b
H = (a==b) & ((b==c) | (a==c))
I = (a==b) | ((b==c) & (a==c))
J = (a<=b) & ((a>c) | (a>d))

% 1 Means True, 0 Means False %