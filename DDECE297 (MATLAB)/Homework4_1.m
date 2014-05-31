% Shaun Mbateng %
% Homework 4_1.m %
% November 2, 2010 %
% This Part Plots f(x) Function %

clc
clear

disp('Shaun Mbateng')
disp('Homework 4 Part 1')
disp('November 2, 2010')
disp(' ')

fplot('40./(1 + (x - 4).^2) + 5.*sin(20.*x./pi)',[0,10])
xlabel('x')
ylabel('f(x)')
title('Homework 4 Part 1 Plot')
