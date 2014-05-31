% Shaun Mbateng %
% Homework 4_4.m %
% November 2, 2010 %
% This Part Plots Four Subplots of A Volume %

clc
clear

disp('Shaun Mbateng')
disp('Homework 4 Part 4')
disp('November 2, 2010')
disp(' ')

r = [0:1:10];
r2 = log(r);
V = (4/3)*pi.*r.^3;
V2 = log(V);

subplot(2,2,1)
plot(r,V)
xlabel('Radius, (r)')
ylabel('Volume, (V)')
title ('Sphere Volume vs. Radius Linear Plot')
grid

subplot(2,2,2)
semilogy(r2,V)
xlabel('Radius, (r)')
ylabel('Volume, (V)')
title ('Sphere Volume vs. Radius Semilog Plot 1')
grid

subplot(2,2,3)
semilogy(r,V2)
xlabel('Radius, (r)')
ylabel('Volume, (V)')
title ('Sphere Volume vs. Radius Semilog Plot 2')
grid

subplot(2,2,4)
loglog(r2,V2)
xlabel('Radius, (r)')
ylabel('Volume, (V)')
title ('Sphere Volume vs. Radius Loglog Plot')
grid
% This plot is a straight line, showing that the relationship between
% Volume and Radius is Logarithmic %
