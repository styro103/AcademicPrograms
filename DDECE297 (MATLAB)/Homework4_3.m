% Shaun Mbateng %
% Homework 4_3.m %
% November 2, 2010 %
% This Part Plots the Tension Test %

clc
clear

disp('Shaun Mbateng')
disp('Homework 4 Part 3')
disp('November 2, 2010')
disp(' ')

% Part a %
e = [0:0.001:0.01];
it = [0 3500 6300 9200 11500 13000 13500 13900 14100 14300 14500];
dt = [0 0 3000 6000 8800 11100 12300 13500 14000 14300 14500];
plot(e,it,'.',e,dt,'*',e,it,e,dt)
xlabel('Elongation   (\epsilon)   Inches')
ylabel('Tension   (\sigma)   Pound Force')
title('Tension Test on a Steel Bar')
grid
gtext('Increasing Tension Force')
gtext('Decreasing Tension Force')

%Part b %
it1 = interp1(e,it,0.00788,'linear');
it2 = interp1(e,it,0.00788,'spline');
fprintf('The Increasing Tension Force at an Elongation of 0.00788 in \n') 
fprintf('is %.2f lbf with Linear Interpolation and %.2f lbf with Spline Interpolation. \n',it1,it2)
