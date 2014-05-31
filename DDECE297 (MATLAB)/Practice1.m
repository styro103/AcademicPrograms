% Shaun Mbateng %
%Practice 1 &
% September, 2, 2010 %

clc
clear

disp('Problem 1')
result = 509^(1/3) - 4.5^2 + log(200)/1.5 + sqrt(75)

disp ('Tenth Value of Vectors')
V1 = [2:0.125:5];
V2 = linspace(2,5,25);
disp(V1(10))
disp(V2(10))

disp('Matricies')
A = [5.6,-2.4,12;3.8,14.0,-5.5;3.0,4.2,-0.5]
A2 = A(1:2,:)
B =[A2'] 
C = [A,B]
D = sqrt(abs(A))
E = ceil(A)
