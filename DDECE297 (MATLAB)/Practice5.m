% Shaun Mbateng %
% Practice 5 %
% September 30, 2010 %

clc
clear

disp('Shaun Mbateng')
disp('Practice 5')
disp('September 30, 2010')
disp(' ')

load matrix_1.txt
matrix_1
A = matrix_1(:,1:4)
b = matrix_1(:,5)
x = inv(A)*b;
sub = [1:1:4];
table = [sub;x']

fid = fopen('Practice5Answers.txt', 'w');
fprintf(fid,'Subscript   X Value\n');
fprintf(fid, '%4.0f %8.3f \n', table);
fclose(fid);