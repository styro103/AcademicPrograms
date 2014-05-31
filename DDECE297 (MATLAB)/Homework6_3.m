% Shaun Mbateng %
% Homework 6_3.m %
% December 8, 2010 %
% Given Height Formula, Calculates Time 3 Different Ways %

clear
clc

% Part a: Polynomial
hc = [0.00001 -0.0013 0 2.13 0 60];
values = roots(hc);
v = find(values > 0);
values = values(v);
time1 = min(values);
fprintf('The rocket hits the ground after %.2f seconds.\n',time1)

% Part b: While Loop
t = 0;
h = 60;
while h > 0
    t = t + 0.01;
    time2 = t;
    h = 0.00001.*t.^5 - 0.0013.*t.^4 + 2.13.*t.^2 + 60;
end
fprintf('The rocket hits the ground after %.2f seconds.\n',time2)

% Part c: Vector
t = [0:.01:60];
h = 0.00001.*t.^5 - 0.0013.*t.^4 + 2.13.*t.^2 + 60;
value = find(round(h) == 0);
time3 = t(value);
fprintf('The rocket hits the ground after %.2f seconds.\n',time3)

