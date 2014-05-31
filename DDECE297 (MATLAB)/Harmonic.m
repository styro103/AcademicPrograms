% Shaun Mbateng %
% Homework 5_3.m %
% November 16, 2010 %
function HM = Harmonic(x);
    % Finds Harmonic Mean
    n = length(x)
    HM = n./sum(x.^-1);


end

