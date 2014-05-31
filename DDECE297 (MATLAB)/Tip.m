% Shaun Mbateng %
% Tip Program %
% November 18, 2010 %

clear
clc

disp('This will show you how much to tip')
disp('')
cost = input('What was the cost of the meal? \n');
response = input('Was the service poor, fair, or good? \n', 's');
response = lower(response);
switch response
    case lower('poor')
        tip = cost*.05;
    case lower('fair')
        if cost*.15 < 1
            tip = 1;
        else
            tip = cost*.15;
        end
    case lower('good')
        if cost*.2 < 2
            tip = 2;
        else
            tip = cost*.15;
        end
    otherwise
        disp('That is not one of the types of services asked for.')
        tip = -1000;
end

total = cost + tip;

if tip ~= -1000
    fprintf('The cost is $%.2f, you should tip $%.2f, \n', cost, tip)
    fprintf('bringing the total to $%.2f.',total)
end
