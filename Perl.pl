#!/usr/bin/perl
use warnings;
use strict;

my $filename = 'txt.txt';

open(FH, '<', $filename) or die $!;

while(<FH>){
   print $_;
}

close(FH);