#!/usr/bin/perl -w 

# read a string
my $string=<STDIN>;
chomp $string;

if( $string =~ /((a|b)*baa)\1/ )
{
  print "I hear sheep!\n";
  print "$1\n";
  print "$&\n";
}
else
  { print "No match - no sheep.\n";
}

