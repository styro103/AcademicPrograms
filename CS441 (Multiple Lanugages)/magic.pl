#!/usr/bin/perl -w 

# read a string
my $string=<STDIN>;
chomp $string;

$string =~ s/\bbaa\b/neigh/ig;
print "$string\n";

