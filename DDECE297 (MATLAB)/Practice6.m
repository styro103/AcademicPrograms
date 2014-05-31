% Shaun Mbateng %
% Practice 6 %
% October 21, 2010 %

clc
clear

disp('Shaun Mbateng')
disp('Practice 6')
disp('October 21, 2010')
disp(' ')

t = [0 10 20 40];
t2 = [0:0.1:40];
V = [120 45 15 2];
V2 = 113.*exp(-0.098.*t2);
plot(t, V, 'o', t2, V2, ':')
xlabel('Time, (t), Seconds')
ylabel('Voltage, (V), Volts')
title('Capacitor Voltage During Discharge')
grid
legend('Data Points', 'Theoretical Curve')
gtext('Shaun Mbateng')
pause
semilogy(t, V, 'o', t2, V2, ':')
xlabel('Time, (t), Seconds')
ylabel('Voltage, (V), Volts')
title('Capacitor Voltage During Discharge')
grid
legend('Data Points', 'Theoretical Curve')
gtext('Shaun Mbateng')