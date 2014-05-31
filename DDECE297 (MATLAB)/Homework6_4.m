% Shaun Mbateng %
% Homework 6_4.m %
% December 8, 2010 %
% Calculates Temperature in A Heat Transfer

clear
clc

T1 = 70;
T2 = 200;
L = 2;
W = 2;
for x = 0:0.2:2.0
        for y = 0:0.2:2.0
            ssum = 0;
            for n = 1:2:101
                ssum = ssum + (2./n).*sin(n.*pi.*x./L).*((sinh(n.*pi.*y./L))/sinh(n.*pi.*W./L));
            end
            wsum = 2./pi.*ssum;
            T = (T2 - T1).*wsum + T1;
            fprintf(' %.1f ',T)
        end
            fprintf('\n')
end

