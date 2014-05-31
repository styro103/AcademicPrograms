% Shaun Mbateng %
% Solar %
% October 21, 2010 %

clc
clear

disp('Shaun Mbateng')
disp('Solar Graph')
disp('October 21, 2010')
disp(' ')

t = [0.303, 0.410, 0.711, 0.793, 0.957, 0.765, 1.034, 1.191, 1.391, 1.517, 1.692, 1.890, 2.128, 2.29, 2.584, 2.775, 2.903, 2.953];
x = [0.5, 1, 1.5, 2.5, 4, 6, 9, 12, 15, 19, 23, 28, 34, 40, 47, 55, 65, 75];
c = polyfit(t, x, 1)
c2 = polyfit(t, x, 2)
x1 = 26.1894*t - 16.8511;
x2 = 8.0391*t.^2 - 0.7387*t - 0.1478;
plot(t, x, 'o', t, x1, t, x2, ':')
xlabel('Time, (t), Seconds')
ylabel('Distance, (x), Inches')
title('Distance Traveled by Solar Car as a Function of Time')
grid
legend('Data Points', 'Linear Equation', 'Quadratic Equation')