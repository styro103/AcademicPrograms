#!/usr/bin/perl -w
use strict;
use Getopt::Std;

sub conv {
    my ($val, $fac) = @_;
    ref $fac ?
        $fac->[0]->($val) :
        $val * $fac;
}

sub reverse_conv {
    my ($val, $fac) = @_;
    ref $fac ?
        $fac->[1]->($val) :
        $val / $fac;
}

use constant SRC => 0;
use constant DST => 1;
use constant FAC => 2;

my @table = (
    #### temperature
    [ c => f => [
        sub { ($_[0] * 9/5) + 32 },
        sub { ($_[0] - 32) * 5/9 },
    ]],
    [ c => k => [
        sub { $_[0] + 273.16 },
        sub { $_[0] - 273.16 },
    ]],

    #### mass/weight
    [ kg   =>  g =>   1000 ],
    [ floz =>  g =>     30 ],
    [ lbs  => kg => 0.4536 ],

    #### distance
    [ ft   => m  =>   0.3048 ],
    [ ft   => in =>       12 ],
    [ in   => cm =>     2.54 ],
    [ m    => cm =>      100 ],
    [ yd   => m  =>   0.9144 ],
    [ km   => m  =>     1000 ],
    [ mile => km => 1.609347 ],
);

my @unit = sort keys %{{
    map +($_->[SRC] => 1, $_->[DST] => 1), @table
}};

die << "END_USAGE" unless getopts('ap:', \my %opt) and @ARGV and (0 ==
+ @ARGV % 2);
usage:  unitconv [-a] [-p precision] <val> <unit> [<val> <unit> [..]]
    -p     the number of decimal places [default: 2]

    -a     force all possible conversions to be shown, even if
           insufficient display precision truncates the value to 0

    <unit> can be one of: @unit

    Results will be printed on one line per input val/unit pair.
END_USAGE

my $prec = $opt{p} || 2;

while(@ARGV) {
    my (%val, $keys_before) = reverse splice @ARGV, 0, 2;

    do {
        $keys_before = keys %val;
        for(@table) {
            $val{$_->[DST]} = conv($val{$_->[SRC]}, $_->[FAC])
                if exists $val{$_->[SRC]}
                and not exists $val{$_->[DST]};

            $val{$_->[SRC]} = reverse_conv($val{$_->[DST]}, $_->[FAC])
                if exists $val{$_->[DST]}
                and not exists $val{$_->[SRC]};
        }
    } until ($keys_before == keys %val);

    unless($opt{a}) {
        sprintf("%.*f", $prec, $val{$_}) == 0 and delete $val{$_}
            for keys %val;
    }

    printf "% 8.${prec}f %s " x keys(%val) . "\n",
        map +($val{$_} => $_), sort keys %val;
}