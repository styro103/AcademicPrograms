% Shaun Mbateng %
% Homework 5_5.m %
% November 16, 2010 %
% Finds Above Freezing Temperatures of NYC and Anchorage %

clc
clear

NYCT = [31 26 30 33 33 29 41 41 34 33 ...			
45 42 36 39 37 45 43 36 41 37 ...			
32 32 35 42	38 33 40 37	36 51 ...			
50];

AT = [37 24 38 25 21 28 46 37 36 20 ...
24 31 34 40 43 36 34 41 42 35 ...
38 36 35 33 42 42 37 26 20 25 ...
31];

T1 = NYCT > 32;
T2 = AT > 32;
T = T1 + T2;
 

disp('The temperatures of both New York City and Anchorage were above')
disp('freezing on the following days in January of 2001:')
disp('')

Day_Number = find(T == 2)
DN = length(Day_Number);
disp('')
fprintf('a total of %.0f days.',DN)