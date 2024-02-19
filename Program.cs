using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;


/*

Okay so basically I need to find the factorial of 

a number. 

Now I think the way I'm going to do this is 


Create a loop and through the numbers 

that are contained in 5 factorial. 

Instead of incrementing the counter and starting 
at zero I'll decrement the counter and start at the 

amount of the number we are trying to factorial. 


Okay so that sounds good. 

So first of all I'll need a number representing the factorial input 

then I'll need a variable to contain the result from the factorial. 


Okay so let's start out with multiplying the number with another 

number one less that the actual number. 

To make sure I'm doing this I can basically just print out the 

counter and I can print out the result of what I'm multiplying. 

Then if needs be I can change a few things. 







*/


int input = 13;


int fact = 0;

int counter = input;
Console.WriteLine("this is the counter");
Console.WriteLine(counter);


// Why is this for loop not running 

int i = input -1;

int finalFact = 0; 


while (i > 0){

    input = input * i;
    finalFact += fact;
    Console.WriteLine("this is the current final fact");
    Console.WriteLine(finalFact); 
    
    
    Console.WriteLine("this is the input");
    Console.WriteLine(input);
    
    Console.WriteLine("this is the current counter");
    Console.WriteLine(i); 
    i--;
    Console.WriteLine("this is the current factorial");
    Console.WriteLine(fact); 

}



Console.WriteLine("Hello World!"); 