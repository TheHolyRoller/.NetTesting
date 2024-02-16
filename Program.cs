using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;

/*


Okay so basically I'm given the number of mangoes that is being 

bought and the price for each mango. 

The discount for mangoes is if three mangoes are bought 
one of those three is for free if more than three mangoes is bought 
and the total number is less than two sets of three then 
one mango is free. 

So basically there is one mango for free for every set of three 
mangoes and the free mango is included in that set of three. 

So if you buy three mangoes you pay for two. 


Then if you buy six mangoes that is two sets of three and 
because it's two sets of three then you get one mango for free 

for each set of three that you bought. 


Okay so the way I'm going to do this is by dividing the number by three 

and flooring the result so that the result is a whole positive integer. 

Then I can take the integer and subtract is from the total number 

of mangoes bought and then I can the number of mangoes 
being bought after the discount is applied and then I can multiply that 
number with the price and get the actual price paid for the mangoes 

with the discount applied. 

Okay so first of all I'll need the mango number and price input. 

Then I'll move on from there 






























*/

int quantity = 13;

int price = 5;


// Create the sub routine to divide the quantity and floor the result 

// var discount = (int)Math.Floor(quantity / 3);
var numPairs = (int)Math.Floor((double)quantity / 3); // cast to double

Console.WriteLine("this is the numPairs");
Console.WriteLine(numPairs);


// Now apply that discount to the price 

int discount  = quantity - numPairs;


int actualPrice = discount * price;

Console.WriteLine("this is the actual price");
Console.WriteLine(actualPrice); 



Console.WriteLine("Hello World!"); 