# Shaun Mbateng
# CS 441 - Sorenson
# Scripting Project Part 2
# This part converts from English Units to Metric

#!/usr/local/bin/perl

print "\n"; #Print Line
print "***English to Metric Unit Converter***"; #Print Line
print "\n"; #Print Line
print "\n"; #Print Line
open (MYFILE, 'Measurements.txt'); #Open Measurements File
while (<MYFILE>) #While Open
{
	chomp; #Chomp Line
	my $var = $_; #Initialize var to Current Line
	my $cv = NULL; #Initialize cv
	my $unit = NULL; #Initialize unit
	
	if(($_ =~ /([0-9]+) in/i) || ($_ =~ /([0-9]+) ft/i) || ($_ =~ /([0-9]+) yd/i) || ($_ =~ /([0-9]+) mi/i)) #If Line is number then English unit
	{
		$cv = $1; #Make cv = Number Value
		$unit = $_; #Make Unit = Line
		$unit =~ s/$1//; #Get unit part of line
		$unit =~ s/^\s+|\s+$//g; #Remove Blank Spaces from Unit
		
		#Convert to inches if Necessary
		if($unit eq "mi") #From mi
		{
			$cv = $cv*63360;
		}
		elsif($unit eq "yd") #From yd
		{
			$cv = $cv*36;
		}
		elsif($unit eq "ft") #From ft
		{
			$cv = $cv*12;
		}
		
		$cv = $cv*2.54; #Convert to cm
		$unit = "cm"; #Unit is cm
		
		#Convert to Highest Possible Singular Metric Unit, if Necessary
		if($cv >= 100000) #To km
		{
			$cv = $cv/100000;
			$unit = "km";
		}
		elsif($cv >= 100) #To m
		{
			$cv = $cv/100;
			$unit = "m";
		}
		
		$var = join " ", $_, "=", $cv, $unit; #Put Strings Together to Make var
	}
	
	print $var; #Print var
	print "\n"; #Print Line
}
close (MYFILE); #Close File
print "\n"; #Print Line

# Sample Run
# smbateng@thomas(11:36:33)~/Files/CS441 (Multiple Lanugages)>perl convert.pl

# ***English to Metric Unit Converter***

# 1 in = 2.54 cm
# 1 ft = 30.48 cm
# 1 yd = 91.44 cm
# 1 mi = 1.609344 km

# smbateng@thomas(11:36:38)~/Files/CS441 (Multiple Lanugages)>
