% Shaun Mbateng %
% Homework 4_2.m %
% November 2, 2010 %
% This Part Plots the Fuel Line Pressure Data %

clc
clear

disp('Shaun Mbateng')
disp('Homework 4 Part 2')
disp('November 2, 2010')
disp(' ')

s = [1:1:10];
psi = [26.1 27.0 28.2 29.0 29.8 30.6 31.1 31.3 31.0 30.5];
co1 = polyfit(s,psi,1);
co2 = polyfit(s,psi,2);
co3 = polyfit(s,psi,3);
psi1 = co1(1).*s + co1(2);
psi2 = co2(1).*s.^2 + co2(2).*s + co2(3);
psi3 = co3(1).*s.^3 + co3(2).*s.^2 + co3(3).*s + co3(4);
plot(s,psi,'.',s,psi1,s,psi2,s,psi3)
xlabel('Time, (s), Seconds')
ylabel('Pressure, (psi), Pounds per Square Inch')
title('Fuel Line Pressure Data')
grid
legend('Data Points', 'Linear Equation', 'Quadratic Equation', 'Cubic Equation')