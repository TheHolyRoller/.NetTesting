using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;


/*


Okay so I think I'm starting to get an idea of how this all works. 

First of all I'm given the total number of blue & red marbles. 

Then I'm given the number of blue and red marbles taken out. 

Then I need to get the total number of marbles and then I need to 


get the total number of blue and then red marbles minus the ones 

that have been taken out. 

So basically I need to calculate the total number of marbles that have been 
taken out by adding up the blue and red marbles and then find the difference 
of that between the marbles that have been added into the bag. 

Then one I have the difference I have the net total number of marbles in the 
bag. 

Once I have that number then I need to calculate the net total number 

of red marbles and then the net total of blue marbles. 

Then once I have that number I can divide it by the total amount of marbles 
that there are in the bag and get back a decimal number so a 
double and this should be the probability of getting a 
marble of a certain color. 

The only problem is now I'm not sure what I need to return. 

Do I need to return the probability of getting a blue & red marble 

in the same number or do I need to return the probability of return a blue 
marble or a red marble? 


So what I can do is experiment and see what combination returns the result 
required as shown in the tests. 


Okay so it seems as though things are clearer. 


First of all I only need to calculate the probability of reaching 
for a blue marble. 

I don't need to calculate the probability of reaching for a red marble. 

Okay so let's just recap. 

In order to find the actual probability of reaching for a blue marble 

I need to calculate the number of net marbles in the bag. 

Then I need to calculate the number of blue marbles and then divide 
that number by the total number of marbles in the bag including the 
blue marbles in the bag. 

Then once that is done then I have the probability of reaching for a 
blue marble. 



Okay so now let's create the input variables and then 

I'll add the logic into the function that will do the addition subtraction 
and necessary calculation tasks. 

Then I can print out the resulting number. 


Okay so first of all I'll need the total number of blue marbles and then 
the total number of red marbles. 

Then I'll need the total number of blue & red marbles being removed. 

Then I'll need variables to store the net number of blue & red marbles and 

then I'll need another variable to store the total number of marbles in the 
bag. 

Then I'll need to create a simple sub-routine in order to calculate the 
probability of choosing a blue marble. 


*/

// Create the variable to hold the number of blue marbles here 
uint blueMarbles = 5;

uint redMarbles = 5;

uint bluePulled = 2;

uint redPulled = 3;


uint totalMarbles = 0;


uint totalBlue = 0;



// Calculate the total number of Red marbles 
uint totalRed = redMarbles - redPulled;
Console.WriteLine("this is the net total number of red marbles minus the ones removed");
Console.WriteLine(totalRed); 



// Calculate the total number of blue marbles here 

uint blueTotal = blueMarbles - bluePulled;

Console.WriteLine("this is the net total number of blue marbles after some have been removed");
Console.WriteLine(blueTotal); 



// Calculate the total number of marbles here 

totalMarbles = blueTotal + totalRed;

Console.WriteLine("this is the net total number of marbles");
Console.WriteLine(totalMarbles); 



// Calculate the probability of choosing a blue marble here 

// double blueProb = blueTotal / totalMarbles;
double blueProb = blueTotal / totalMarbles;

Console.WriteLine("this is the probability of choosing blue");
Console.WriteLine(blueProb); 











Console.WriteLine("Hello World!"); 