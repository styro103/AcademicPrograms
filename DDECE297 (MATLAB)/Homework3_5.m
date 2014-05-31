% Shaun Mbateng %
% Homework 3_5.m %
% October 6, 2010 %
% Test Scores %

clc
clear

disp('Shaun Mbateng')
disp('Homework 3 Part 5')
disp('October 6, 2010')
disp(' ')

load TestScores.txt
TestScores

Students = TestScores(1:20,2:4);
Tests = TestScores(1:20,2:4)';
Avg1 = mean(Tests);
Avg2 = mean(Students);
disp('Average Test Score')
Avg = mean(Avg2)
High = max(Students);
Low = min(Students);
Mid = median(Students);
Table1 = [TestScores,Avg1']';

fid = fopen('TestScoresStats.txt', 'w');
fprintf(fid,'Student Number	   Test 1	   Test 2	   Test 3    Student Test Average\n');
fprintf(fid, '   %.0f              %.0f          %.0f          %.0f                 %.2f\n', Table1);
fprintf(fid,'Test Average      %.2f        %.2f      %.2f\n',Avg2);
fprintf(fid,'Test Low          %.2f        %.2f      %.2f\n', Low);
fprintf(fid,'Test High         %.2f       %.2f      %.2f\n', High);
fprintf(fid,'Test Median       %.2f        %.2f      %.2f\n', Mid);
fclose(fid);

