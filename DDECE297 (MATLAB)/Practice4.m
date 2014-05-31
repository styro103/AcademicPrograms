% Shaun Mbateng %
% Practice 4 %
% September 23, 2010 %

clc
clear

disp('Shaun Mbateng')
disp('Practice 4')
disp('September 23, 2010')
disp(' ')

o = input('Enter Initial Inches Value. ');
f = input('Enter Final Inches Value. ');
inc = input('Enter Inches Increment. ');
in = [o:inc:f]';
cm = 2.54.*in;
ft = in./12;

% Display Table Using Display Command %
table1 = [in,cm,ft];
disp('Conversions From Inches to Centimeters and Feet')
disp('     in        cm        ft')
disp(table1)
% Display Conversions Using frpintf Command %
fprintf('\n')
fprintf('     in        cm        ft')
fprintf('\n')
fprintf('     %.2f     %.2f     %.2f\n', table1')