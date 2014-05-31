% Shaun Mbateng %
% Homework 3_2.m %
% October 6, 2010 %
% Inputs Force Values, Calculates and Displays Displacement and Potential Energy  %

clc
clear

disp('Shaun Mbateng')
disp('Homework 3 Part 2')
disp('October 6, 2010')
disp(' ')

F = input('Enter Force Values (If Inputting a Vector of Matrix, \n Use Brackets, Commas, and Semicolons Where Necessary).\n ');
k = input('Enter Spring Constants (If Inputting a Vector of Matrix, \n Use Brackets, Commas, and Semicolons Where Necessary).\n ');
x = F./k;
PE = (k.*x.^2)./2;
disp('')
format short g;
disp('            F           k           x           PE ')
disp('           (N)        (N/m)        (m)          (J)')
disp([F' k' x' PE'])