% Shaun Mbateng %
% Homework 5_2.m %
% November 16, 2010 %
function O = Angles(a,b,c);
    % Given Sides of A Triangle, Finds the Angles
    A = acosd((b.^2 + c.^2 - a.^2)/(2.*b.*c));
    B = acosd((a.^2 + c.^2 - b.^2)/(2.*a.*c));
    C = acosd((a.^2 + b.^2 - c.^2)/(2.*a.*b));
    O = [A,B,C];
end
