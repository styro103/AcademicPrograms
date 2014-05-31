% Homework 2 %
% Shaun Mbateng %
% September 23, 2010 %
clc

disp('Shaun Mbateng')
disp('Homework 2')
disp('September 23, 2010')
disp(' ')

disp('Problem 1')
disp ('Part a')
u = [5, 4, -7];
v = [3; -1; -8];
u * v
disp('Part b')
dot(u,v)

disp('Problem 2')
A = [2.5, 8; 4.2, 7.8]
B = [5, 4; 2, 3]
disp ('Part a')
C1 = A*B
disp ('Part b')
C2 = B.^2
disp ('Part c')
C3 = A.*B
disp ('Part d')
C4 = A.^B

disp ('Problem 3')
disp ('Part a')
D1 = B.*B
disp ('Same Result')
disp ('Part b')
D2 = A.*inv(B)
disp ('Part c')
D3 = A*B
D4 = B*A
disp('C3, D3, and D4 are Each a Different Matrix')
disp ('Part d')
(A*B)'
B'*A'
disp('They are the Same Matrix')

disp ('Problem 4')
x = [-2,-1,0,1,2,3,4,5];
y = ((2.*x.^2 - 5.*x + 4).^3)./(x.^2)

disp ('Problem 5')
disp ('Part a')
F = [11,7,8,10,9]
k = [1,2,3,4,5]
disp ('Part b')
x = F./k
disp ('Part c')
PE = (k.*x.^2)./2

disp ('Problem 6')
t = [0:2:20];
Theta = 79;
vi = 100;
g = 9.81;
x = vi*cosd(Theta).*t;
y = vi*sind(Theta).*t - 0.5*g.*t.^2;
r = sqrt(x.^2 + y.^2)

disp ('Problem 7')
x = [1,0.5,0.1,0.01,0.001,0.00001,0.0000001];
y = (exp(x) - 1)./x

disp ('Problem 8')
disp ('Pi')
pi
disp('Part a')
n = [0:1:100];
s = ((-1).^n)./(2.*n + 1);
4.*sum(s)
disp('Part b')
n = [0:1:10000];
s = ((-1).^n)./(2.*n + 1);
4.*sum(s)
disp('Part c')
n = [0:1:1000000];
s = ((-1).^n)./(2.*n + 1);
4.*sum(s)

disp ('The Limit Approaches Pi')

disp ('Problem 9')
disp ('Part a')
u = [0:0.05:1]
disp ('Part b')
k = 0.25;
p = (k.*u.*(1 - u))./(k + u)
disp ('Part c')
max(p)
disp ('Part d')
u = [0:0.01:1];
k = 0.25;;
q = (k.*u.*(1 - u))./(k + u);
E = abs((max(q) - max(p))/max(p)).*100