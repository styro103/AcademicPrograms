% Shaun Mbateng %
% Homework 6_1.m %
% December 8, 2010 %
% Calculates Geometric Quantities of A Given Radius %

clear
clc

running = 'y';

while running == 'y'
    r = input('Enter the radius \n');
    fprintf('What would you like to calculate?\n')
    calculate = input('Enter "Circumference", "Area", "Surface Area", or "Volume"\n','s');
    calculate = lower(calculate);
    switch calculate
        case 'circumference'
            C = 2.*pi.*r;
        case 'area'
            C = pi.*r.^2;
        case 'surface area'
            C = 4.*pi.*r.^2;
        case 'volume'
            C = (4/3).*pi.*r.^2;
        otherwise
            fprintf('That is not one of the choices.')
            C = -1000;
    end
    if C ~= -1000
        fprintf('The ')
        fprintf(calculate)
        fprintf(' is %.2f.\n',C)

        running = input('Do another calculation? Type "y" of "n" \n','s');
        fprintf('\n')
    else
        running = input('Do another calculation? Type "y" of "n" \n','s');
    end   
end