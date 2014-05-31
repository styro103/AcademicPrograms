% Shaun Mbateng
% DD 297 Final Test A
% December 10, 2010
% Question 1

clear
clc

disp('Final Question 1')
A = [3 2 -1
    -1 3 2
    1 -1 -1];
B = [10;5;-1];

M = [A,B];

fprintf('     x     y     z   ans\n')
disp(M)
disp(' ')

r = inv(A)*B;

x = r(1);
y = r(2);
z = r(3);

fprintf('The values of x, y, and z are %.0f, %.0f, and %.0f respectively.\n',x,y,z)