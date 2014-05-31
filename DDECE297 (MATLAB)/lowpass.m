% Shaun Mbateng %
% Lowpass %
% October 28, 2010 %

clc
clear

f = [10, 500, 1000, 2000, 3000, 5000, 10000, 50000];
output = [1, 0.96, 0.88, 0.7, 0.55, 0.36, 0.2, 0.04];
subplot(2,1,1)
plot(f, output, 'x-')
xlabel('Frequency, (f), Hertz')
ylabel('Transfer Function')
title('Lowpass Filter Output (Linear Plot)')
grid
subplot(2,1,2)
semilogx(f, output, 'x-')
xlabel('Frequency, (f), Hertz')
ylabel('Transfer Function')
title('Lowpass Filter Output (Semilog Plot)')
grid