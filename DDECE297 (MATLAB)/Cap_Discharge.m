% Shaun Mbateng %
% Capacitor Discharge %
% October 28, 2010 %

clc
clear

t = [0, 10, 20, 40];
v = [120, 45, 15, 2];
t2 = [0:.1:40];
v2 = 113*exp(-0.098*t2);
subplot(3,1,1)
plot(t,v, 'o', t2, v2,'-')
xlabel('Time, (t), Seconds')
ylabel('Voltage, (v), Volts')
title('Capacitor Discharge')
grid
subplot(3,1,2)
plot(t,log(v), 'd', t2,log(v2),'-')
xlabel('Time, (t), Seconds')
ylabel('Voltage, (v), Volts')
title('Capacitor Discharge')
grid
subplot(3,1,3)
semilogy(t,v,'o', t2,v2,'-')
xlabel('Time, (t), Seconds')
ylabel('Voltage, (v), Volts')
title('Capacitor Discharge')
grid
