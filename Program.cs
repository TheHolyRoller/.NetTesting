using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;

/*

Okay so I think one of the ways this could work is to take the n 

which is the total number of blue beads and divide it by two because 
every two sets of blue beads there is an extra red bead 
so one more red bead than there is a blue bean. 

Then if I did the modulus operator then I could also get the remainder and if 
the remainder is less than two then I could just add one onto the division 
of that number by two. 

Then I take the current number of blue beads and I add this extra 

number onto it. 

Okay so that sounds great. 



*/


int blueBeads = 2466;

Console.WriteLine("this is the blue beads"); 

Console.WriteLine(blueBeads); 


// Now divide 5 by two 

int redBeads = blueBeads / 2;

Console.WriteLine("this is the division result");
Console.WriteLine("this is the redBeads number also");
Console.WriteLine(redBeads); 

if(redBeads >= 2){

double remainder = 5 % 2;
Console.WriteLine("this is the remainder");
Console.WriteLine(remainder); 


if(remainder < 2 && remainder > 0){
    redBeads += 1; 

}

}

int totalRedBeads = blueBeads + redBeads; 



Console.WriteLine("this is the updated red bead number");
Console.WriteLine(redBeads);


Console.WriteLine("this is the red bead total after the calculations");
Console.WriteLine(totalRedBeads); 



Console.WriteLine("Hello World!"); 