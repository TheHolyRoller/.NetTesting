// Add in the imports here 
using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;


/*

Okay so it seems like the overall concept is pretty simple. 

First of all I need to calculate how many people are on the best at the end of the 

day when the bus has reached it's final destination. 

Okay so in theory what I need to do is have one sum variable that keeps track 

of the total number of people on the bus. 

Then I take each pair that I'm given and I take the first number and I subtract the 

second number from the first number and I store the result in an integer variable 

then this integer variable stores the number of people that have currently got on the 
bus or the number of people that are getting off the bus at any given stop 
thus the number could be positive therefore the number of people on the bus will 
be increasing or the number could be negative and thus the number of people on the 
bus will be decreasing. 

It should not matter too much if the number that results from the subtraction of 

the number pairs is negative because if you add a negative number to a positive 

number it's the same as subtraction. 

Okay so that sounds great. 

There are a few unknowns remaining. 

First of all I'm not sure how this whole list pair thing works. 

I'm also, not sure when one list ends and another begins. 

I'm also, not sure how to extract the first and second element of a list pair 
separately. 


Okay so it seems like things are more clear at the moment. 

So basically I'm going to have a variable that keeps track of the total 

a ephemeral variable that is going to hold the current result of the difference 

of the two numbers of a pair and then I'm going to add that difference of that 

pair to the main total variable. 

The way I'm going to access each pair is through the use of a for each loop. 

Then I'll access the first and second element of each element that is looped through 
and I'll get the difference of each pair and then I'll add the difference to the 

total. 


Okay so that seems quite straight forward. 

So first of all I'm going to construct the list of pairs. 

Then I'm going to create the variables. 

Then I'm going to loop through the List perform the actions and 

then print out the result. 








*/


List<(int, int)> list = new List<(int, int)>()
{
    (3, 0),
    (9, 1),
    (4, 8), 
    (12, 2), 
    (6, 1), 
    (7, 8)
};

// Log the type of the list here 
Console.WriteLine("this is the type of list");
Console.WriteLine(list.GetType().Name); 



// Create the total variable here 
int total = 0;

// Create the difference variable here 
int difference = 0; 


// Loop through the List here 
foreach(var elem in list){

    Console.WriteLine("this is the current pair item");
    Console.WriteLine(elem);

    Console.WriteLine("this is the type of element");
    Console.WriteLine(elem.GetType().Name); 
    

    Console.WriteLine("this is the first pair item");
    Console.WriteLine(elem.Item1);

    Console.WriteLine("this is the type of the first item of the pair");
    Console.WriteLine(elem.Item1.GetType().Name); 
    

    Console.WriteLine("this is the second item of the current pair");
    Console.WriteLine(elem.Item2); 
    

    // Get the two pairs here 
    difference = elem.Item1 - elem.Item2;

    Console.WriteLine("this is the difference of the two pairs");
    Console.WriteLine(difference); 

    // Get the difference of the two pairs here 
    total += difference;

    Console.WriteLine("this is the new total ");
    Console.WriteLine(total); 
    
    // Add the difference onto the total here 
    difference = 0;

    Console.WriteLine("this is the reset difference");
    Console.WriteLine(difference); 
    
    
    
    
    // Reset the difference variable here 





}







Console.WriteLine("Hello World!"); 