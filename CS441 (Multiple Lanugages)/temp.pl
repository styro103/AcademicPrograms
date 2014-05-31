#!/usr/bin/perl -w 

# read a string
my $string=<STDIN>;
chomp $string;

if( $string =~ /([0-9]+) degrees/i )
{
  print "I hear sheep!\n";
  print "$1\n";
  $celsius = 5.0/9*($1-32);
  $string =~ s/$1/$celsius/;
  
 # print "$&\n";
 # print "$`$celsius degrees celsius$'\n";
  print "$string\n";
}
else
  { print "No match - no sheep.\n";
}

