% Shaun Mbateng %
% Function Program %
% November 4, 2010 %
function h = Height(v,t,A)

    h = v*t*sind(A) - .5*9.81*t^2;
    