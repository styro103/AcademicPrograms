% Shaun Mbateng %
% Homework 3_1.m %
% October 6, 2010 %
% This Part Converts Fahrenheit to Celcius, Kelvin, and Rankine %

clc
clear

disp('Shaun Mbateng')
disp('Homework 3 Part 1')
disp('October 6, 2010')
disp(' ')

F = input('Enter degrees in Fahrenheit. ');
C = (5/9)*(F - 32);
K = C + 273.15;
R = (9/5)*K;

fprintf('%.10g degrees Fahrenheit is equal to %.1f degrees Celsius,\n %.3e Kelvin, and %.5g degrees Rankine. \n',F,C,K,R)