// Add in the imports here 
using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;



/*

Okay so I think I know the basic requirements of what needs 
to be returned. 

First of all I am given a discrete non negative 
integer and the task is to return the factorial of that 

integer. 

So a factorial is a number that is multiplied by all the numbers 
that is contained within it up to and including 1. 

So basically the number 3 would be multiplied by three 
2 and once. 

So three would be multiplied by three which would 
result in 3 and then it would be multiplied by 2 which would 
result in 6 and then six would be multiplied by three 
which would result in 18. 


Okay so the number is multiplied by taking the number 

itself and then multiplying the number itself with the 

next number down from that so one less than the actual number. 

Then the result of multiplying those two numbers together 
is multiplied by the next number down until the number one 
is reached and the result is multiplied by one which 
means that the result will stay the same. 


Okay so I'm given an integer and I need to multiply that 
integer with another integer one less that the original 
integer and then I need to take the result and multiply 
that result with another integer less than the integer 
that was multiplied with the original integer and was one 
less than the original integer. 


Okay so just to clarify things I'll need a variable that 
will hold my current product and then I'll need another 
variable that will hold the current multiplicand. 

So this will be the previous number that had one deducted from it 
and this number will be the previous number minus one. 

It would be nice if I could write the program in a recursive 
manner but let's try and write the program using a 

loop first. So the then the steps are create the input integer and then 
create the loop that will loop the length of the input integer and 
will multiple all the numbers contained in the input integer. 




*/

int input = 4;


// Create the current product variable here 
int currentProduct = input;

int mult = input;

int iterator = 0; 
// Create the loop here 
while( iterator < input -1){

    mult = mult - 1; 
    currentProduct *= mult;
    Console.WriteLine("this is the current product");
    Console.WriteLine(currentProduct); 

    // Increment the iterator here 
    iterator++;

    Console.WriteLine("this is the current iterator");
    Console.WriteLine(iterator); 
    


}



Console.WriteLine("Hello World!"); 




