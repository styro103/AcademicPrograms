% Shaun Mbateng %
% Homework 5_2.m %
% November 16, 2010 %
% Finds Angles of A Triangle %
clc
clear

format bank

a = input('Side a  ');
b = input('Side b  ');
c = input('Side c  ');
O = Angles(a,b,c);
disp('Angle Opposite of a in Degrees')
A = O(1)
disp('Angle Opposite of b in Degrees')
B = O(2)
disp('Angle Opposite of c in Degrees')
C = O(3)