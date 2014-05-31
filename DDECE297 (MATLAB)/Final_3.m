% Shaun Mbateng
% DD 297 Final Test A
% December 10, 2010
% Question 3

clear
clc

a = -20;
b = 20;
n = 12;
vec1 = (b - a)*rand(1,n) + a
vec2 = (b - a)*rand(1,n) + a

% Part a
disp('Final Quesion 3 Part a')
disp(' ')
vec3 = length(find(vec2 > vec1));
fprintf('The Number of Values in Vector 2 That Are Greater Than Their\n')
fprintf('Vector 1 Counterpart is %.0f',vec3)
disp(' ')
disp(' ')

% Part b
disp('Final Quesion 3 Part b')
disp(' ')
value = input('Enter a value ');
vec4 = length(find(vec1 < value));
fprintf('The Number of Vector 1 Values That are Less Than %.g is %.0f',value,vec4)
disp(' ')
disp(' ')

%Part c
vec5 = find(vec1 < 0);
vec6 = vec1(vec5);
table = [vec5;vec6];
disp('Final Quesion 3 Part c')
disp(' ')
disp('Vector 1 Values That Are Negative')
disp('     Position           Value')
fprintf('      %2.0f               %1.2f\n',table)