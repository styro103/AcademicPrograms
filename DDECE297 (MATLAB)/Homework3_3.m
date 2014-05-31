% Shaun Mbateng %
% Homework 3_3.m %
% October 6, 2010 %
% Calculate Unknown Currents %

clc
clear

disp('Shaun Mbateng')
disp('Homework 3 Part 3')
disp('October 6, 2010')
disp(' ')

R1 = 670;
R2 = 1000;
R3 = 1000;
R4 = 100;
R5 = 470;
R6 = 220;
R10 = 390;
V1 = 10;

M =  [R1 0 0 R4 0 0 V1
      0 R2 0 -R4 R5 0 0
      0 -R2 R3 0 0 0 0
      0 0 0 0 -R5 (R6+R10) 0
      -1 1 1 1 0 0 0
      0 -1 -1 0 1 1 0]

A = M(:,1:6);
B = M(:,7);
i = inv(A)*B;
CN = [1:1:6]';

fprintf('\n')
fprintf('Current Number   Value (mA)\n')
fprintf('\n')
fprintf('       %g           %.2f\n', [CN,i.*1000]')

