% Shaun Mbateng %
% Homework 5_4.m %
% November 16, 2010 %
function x = Position(t)
    % Given the time, finds the position of a particle in meters
    for n = 1:length(t)
        if 0<= t(n) & t(n)<=10
            x(n) = 0.5.*t(n).^2;
        elseif 10<t(n) & t(n)<20
            x(n) = 0.05.*t(n).^3 - t(n).^2 + 15.*t(n) - 50;
        elseif 20<=t(n) & t(n)<=30
            x(n) = 0.0025.*t(n).^4 - 0.15.*t(n).^3 + 135.*t(n) - 1650;
        else
            x(n) = 0;
        end
    end

end

