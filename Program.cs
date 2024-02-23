using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks.Dataflow;


/*

Okay so basically I need to round up a number to the nearest multiple of 5. 


I'm just not sure how I'm going to do that they though. 


Well let's start at the most simple base case. 

Well see if it's zero or if it's a multiple of 5. 


Okay and then another thing apparently zero is a  multiple of 5. 

So if I have a negative number that is less that minus five and that is 

less than zero then I can just add the positive value of that negative number. 

Then that will give me zero. 

If a number is a multiple of five or is zero nothing needs to be done. 

But if a number ends in five or a zero it is probably going to be a multiple 

of five. So one way I could do this is by testing different approaches. 


One approach would be to add the difference of five and the ending number of 
the current number I'm checking. 

Then I could possible make the number end in five and turn round it up to 

a multiple of five. 


Okay so I've thought up of another approach. 

What I could do is multiple five up to the point where it's less than 

the number I want to round. 

Then when it's just less I could multiply it one more time and this could 

give me the nearest multiple of five. 

Then I could take the difference of those two numbers the number I'm working 
on and the nearest multiple and I could add it to the number I have 

been given. 

Then I have the nearest multiple. 

Okay so I want to make the number end in a zero or a five. 

To do that there are two main ways. 



Okay so let's try this out. 

I have a for loop that runs until the number is larger than 

the current number what we are trying to get the multiple of. 

Because the for loop runs until it's larger when it is larger it will 

not run anymore and therefore it's most likely that the 

resulting number will be smaller than the number we are trying to round 
up. 

So it will be slightly smaller but not larger. 

That seems to be quite a good middle ground. 

So if it's just slightly smaller but not larger and will most 

likely be larger if the for loop ran one more time then it would appear to 

be optimal or close to optimal as a solution. 

And it definitely won't be the same size as the rounded number because 

the rounded number will not be a multiple of five. 

And if it was it would have already been returned. 


Okay so basically have a while loop that runs as long as the multiple 
number is not greater than the rounded number. 


Then once that has finished we just add five to the multiple and 

that should be the optimum result. 












*/



int input = 12;

int mult = 0; 
// Create the while loop here 
while(input > mult){


    mult += 5;
    Console.WriteLine("this is the new multiple");
    Console.WriteLine(mult); 
    
    
}


Console.WriteLine("this is the resulting multiple"); 
Console.WriteLine(mult);

Console.WriteLine("this is the input");
Console.WriteLine(input);


// mult += 5;
// Console.WriteLine("this is multiple with one more multiple of five added");
// Console.WriteLine(mult);



Console.WriteLine("this is the difference between the multiple & input");

int diff = mult - input;
Console.WriteLine(diff);


input += diff;
Console.WriteLine("this is the input plus the difference");
Console.WriteLine(diff); 











Console.WriteLine("Hello World!"); 