#!/usr/bin/perl -w 
print "hello! I like Perl!\n";

print glob ("* ");
print "\n";

print "Enter your guess: ";
my $number=int(rand(100)+1);
my $guess=<STDIN>;
chomp $guess;
print "$guess and $number \n";
while($guess ne $number)
{
  if($guess lt $number){
    print "Too low!\n";}
  elsif($guess gt $number){
    print "Too high!\n";}
  print "Your guess please? ";
  $guess=<STDIN>;
  chomp $guess;
}
print "You win!!!!!!!!\n";
