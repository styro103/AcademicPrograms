function h = Function(v,t,A)
% Shaun Mbateng %
% Function Program %
% November 4, 2010 %


    clc

    disp('Shaun Mbateng')
    disp('Function Program')
    disp('November 4, 2010')
    disp(' ')

    h = v*t*sind(A) - .5*9.81*t^2;