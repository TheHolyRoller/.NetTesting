// Add in the imports here 
using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;




/*

Okay so it seems like this is a really simple challenge. 

I'm given two parameters. The first parameter is 

the name and the second parameter is the price which is a double. 

It costs 30 dollars per character including spaces in order to put one's 

name on the billboard so the task is to calculate the cost of putting 
one's name on the billboard. 


So basically the way I'm going to go about this is to take the string which 

is the name and then turn it into a character array. 

Then I'll take the length of that character array and then multiply that 
number by the cost of each letter and then I'll store the result in a double 
and return that result. 


Okay so that sounds pretty good. 




*/


// Create the name input here 
string name = "Jeong-Ho Aristotelis";
Console.WriteLine("this is the name input");
Console.WriteLine(name); 
Console.WriteLine("this is the type of the name variable");
Console.WriteLine(name.GetType().Name);

// Create the price input here 
double price = 30;
Console.WriteLine("this is the price per character");
Console.WriteLine(price); 
Console.WriteLine("this is the type of the price variable");
Console.WriteLine(price.GetType().Name);


char[] arr = name.ToCharArray();
Console.WriteLine("this is the type of the arr variable");
Console.WriteLine(arr.GetType().Name);

Console.WriteLine("this is the character Array converted from the string");
Console.WriteLine(arr); 


int len = arr.Length;
Console.WriteLine("this is the length of the character Array");
Console.WriteLine(len);
Console.WriteLine("this is the type of the length variable");
Console.WriteLine(len.GetType().Name); 




double cost = price * len;
Console.WriteLine("this is the cost of the name");
Console.WriteLine(cost); 
Console.WriteLine("this is the type of the cost variable");
Console.WriteLine(cost.GetType().Name);

// Print out the types of these variables here 



Console.WriteLine("Hello World!"); 




