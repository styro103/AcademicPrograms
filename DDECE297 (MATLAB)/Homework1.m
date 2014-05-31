% Shaun Mbateng %
% Homework 1 %

clc
clear

disp ('Shaun Mbateng')
disp('Homework 1')
disp('September 7, 2010')
disp(' ')

disp('Problem 1')
x = 4.8;
y = -14.25;
n1 = 4+5i;
n2 = 5-6i;

a = (3*x^2 + 0.5*y)/(5*x - 8)
b = (1 - (1/x^3))^(-1)
c = 3*(n1 - n2)/(n1 + n2)
d = sqrt(14*x^3)/exp(3*x)
e = log10(abs(x^2 - x^3))

disp ('Problem 2')
result = cos(5*pi/6)^2*sin(7*pi/8)^2 + tan((pi/6)*log(8))/sqrt(7)

disp ('Problem 3')
volume = (4/3)*pi*15^3
disp('cm^3')
length = nthroot(volume, 3)
disp('cm')

disp ('Problem 4')
% Part a %
a = 21;
b = 45;
c = 60;

upsilon  = acosd((c^2 - a^2 - b^2)/(-2*a*b))
disp('degrees')
% Part b %
alpha = asind((sind(upsilon)/c)*a)
beta = asind((sind(upsilon)/c)*b)
% Part c %
disp('alpha + beta + upsilon')
alpha + beta + upsilon

disp('Problem 5')
Containers = ceil(634/18)

disp('Problem 6')
% Part a %
lcm(4, 14)
% Part b %
lcm(8, 42)

disp ('Problem 7')
v1 = [4:(38-4)/(12-1):38]
v2 = linspace(4, 38, 12)

disp ('Problem 8')
Afirst = [3:4:51]
Asecond = [Afirst(1:4),Afirst(11:13)]

disp('Problem 9')
A = [4,7,6,2;4,5,1,3;2,2,3,3;8,9,6,7]
B = [13.2,12.7;-46.5,-28.0;57.6,-6.1;-7.4,10.8]
% Part a %
C1 = A(1:3,:)
% Part b %
C2 = A(2:3,1:2)
% Part c %
C3 = A(:,1:4)
% Part d %
C4 = [C3,B]
% Part e %
disp('A(2,4) * B(2,4,)')
A(2,4)*B(4,2)
% Part f %
B2 = log(abs(B))
% Part g %
B3 = floor(B)

disp('Problem 10')
D = [1:1:5]
E = [2:2:10]
F = [3:3:15]
% Part a %
G = [D;E;F]
% Part b %
H = [G']

disp ('Problem 11')
% Part a %
[zeros(2,3),ones(2,3)]
% Part b %
[ones(4,1),eye(4),zeros(4,1)]
% Part c %
[ones(1,2);zeros(2,2);ones(1,2)]

disp ('Problem 12')
v = [1:1:35]
reshape(v,7,5)'

r=pow(3,4)