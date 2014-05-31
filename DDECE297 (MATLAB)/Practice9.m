% Shaun Mbateng %
% Practice 9 %
% November 18, 2010 %

clear
clc

t = linspace(0, 2*pi, 50);
x = exp(-t).*sin(t);
fprintf('\nYou are to type the calculation to be performed. \n')
response = input('Enter minimum, maximum, or total. \n', 's')
switch response
    case 'minimum'
        value = min(x)
    case 'maximum'
        value = max(x)
    case 'total'
        value = sum(x)
    otherwise
        fprintf('You have not entered a proper choice. \n')
        value = -1000
end

if value ~= -1000
    fprintf('The %s is %.3f\n', response, value)
end