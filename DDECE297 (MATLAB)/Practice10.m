% Shaun Mbateng %
% Practice 10 %
% December 9, 2010 %

clear
clc

% 10.6 Problem 4 Page 307

fplot('0.55*18*9.81*sqrt(x^2+10^2)/(x+0.55*h)-90',[0,20])
x1 = fzero('0.55*18*9.81*sqrt(x^2+10^2)/(x+0.55*h)-90',[8,13])


