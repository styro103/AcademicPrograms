% Shaun Mbateng %
% Practice 4 %
% September 23, 2010 %

clc
clear

disp('Shaun Mbateng')
disp('Practice 4')
disp('September 23, 2010')
disp(' ')

% This Program Calculates the Area of A Circle for A Given Radius %

% Part 1 %
r = 2
A = pi*r^2
% Part 2 %
disp ('The Area of A Circle of Radius')
disp(r)
disp ('is')
disp (A)
disp('Square Units')
% Part 3 %
fprintf('The Area of A Circle of Radius %2.0f is %f Square Units. \n',r,A)
% Part 4 %
    % This Part Has the User Input the Radius %
r = input('Enter a Radius. ');
A = pi*r^2;
fprintf('The Area of A Circle of Radius %2.0f is %f Square Units. \n',r,A)
% Part 5 %
    % This Part Creates A Table of Areas of Circles of Given Radii %
r = [1,2,3,4];
    % Calculate Areas Using Element by Element Exponentation %
A = pi.*r.^2;
    % Create A Table in Two Rows %
table1 = [r;A]
    % Transpose Table to Columns %
table2 = table1'
    % Using the Display Command to Generate the Table %
disp('Area of Circles With Different Radii')
disp('   Radius   Area')
disp('   (Feet)   (Square Feet)')
disp(table2)
    % Now Display Using fprint Command %
fprintf('\n')
fprintf('Radius   Area\n')
fprintf('(Feet)   (Square Feet)\n')
fprintf('\n')
fprintf('  %2.0f        %13.14f\n', table1)