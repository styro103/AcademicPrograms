% Shaun Mbateng %
% Practice 7 %
% November 4, 2010 %

clc
clear

disp('Shaun Mbateng')
disp('Practice 7')
disp('November 4, 2010')
disp(' ')

y = [5 -3 2 0 -1]
x = roots(y)
f = [4 -2 1]
mult = conv(f,y)
[q,r] = deconv(y,f)

