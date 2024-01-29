// Add in the imports here 
using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;


/*

So basically the way this works is I'm given an 

array of boolean expressions and I'm given an operator. 

This operator is a string and can either be an AND, OR, or XOR 

So I need to combine each boolean element in the Array with the 


element following it using the given Operator. 

Then I need to update the current result. 

So first of all I need to extract the operator from the string. 

I could use a switch case statement for this. 

Then once I have the operator I need to iterate through the 

Boolean Array. 

So basically I'll have the operator and I need to perform the 

correct operation on the first element and then the second element. 

Then once that has been done and the boolean result has 

been stored in the boolean variable the 

next iteration of the loop will occur and then the same process 

will be repeated. 

But in order to access the right indices two counter variables 


will need to be used. One counter variable that starts at zero 

and another that starts at one. 

Then these two variables will be incremented after each iteration 
of the for loop. 

I think it would be better to use a for loop instead of a 

for each loop because you have more control of the exact index 

of the array that you are iterating through. 

Okay so basically there is a problem and that problem is how do we 

use the right operator once we have extracted. 


Okay so I've come up with somewhat of a solution. 

First of all I'm going to extract the value of the operator from 

the given string and then depending of the result of the variable that 

has extracted the Operator from the string then one of three for loops are 
run 
and in each of these for loops there is contained a different operator. 

The first one will contain an and operator will perform all the necessary 

operations. 

They will be updated globally scoped variables so after the for loops I can 
just return the values. 





*/


// Create the Array of Boolean values here 
bool[] arr = { true, true, true, false };



// Create the operator here 

string op = "AND";

Console.WriteLine("this is the operator ");
Console.WriteLine(op); 

bool result;

// Create the two counter variables here 
int counter1 = 0;
int counter2 = 1;
bool first = arr[0]; 

// Add in the two boolean variables here 


// Check the operator here and run 
if(String.Equals(op, "AND")){


        // Run the AND for loop here 
        Console.WriteLine("Runnning the And loop "); 
        for(int i = 1; i < arr.Length; i++){

                // Perform the And operations here 
                first = first && arr[i];
                Console.WriteLine("this is the current result ");
                Console.WriteLine(first); 
                
                Console.WriteLine("this is the current index");
                Console.WriteLine(i); 
                

                // Type type = result.GetType();
                // Console.WriteLine("this is the type of result");
                // Console.WriteLine(type.Name); 
                
                
                // Console.WriteLine("this is the current result of boolean result");
                // Console.WriteLine(result);
                // Console.WriteLine("this is the current value of counter1");
                // Console.WriteLine(counter1);
                // Console.WriteLine("this is the current value of counter2");
                // Console.WriteLine(counter2); 
                
        
        }
        


}

if(String.Equals(op, "OR")){

// Run the OR for loop here 

for(int i = 0; i < arr.Length; i++){


                result = arr[counter1] || arr[counter2];
                // counter1++;
                // counter2++;
                // Console.WriteLine("this is the current value of boolean result");
                // Console.WriteLine(result);
                // Console.WriteLine("this is the current value of the first counter");
                // Console.WriteLine(counter1);
                // Console.WriteLine("this is the current value of the second counter");
                // Console.WriteLine(counter2);
                // Console.WriteLine("this is the current value of the i incrementor");
                // Console.WriteLine(i); 
                




}


}

else{


        // Run the XOR for loop here 


        // Create the for loop here 
        for(int i = 1; i < arr.Length; i++){
        
        
        result = arr[counter1] ^ arr[counter2];
                // counter1++;
                // counter2++;

                // Console.WriteLine("this is the current boolean result");
                // Console.WriteLine(result);
                // Console.WriteLine("this is the current value of counter1");
                // Console.WriteLine(counter1);
                // Console.WriteLine("this is the current value of counter2");
                // Console.WriteLine(counter2);
                // Console.WriteLine("this is the current value of i incrementor");
                // Console.WriteLine(i); 
                
        
        
        
        }
        


}


Console.WriteLine("this is the final result of the for loop ");
Console.WriteLine(first); 




// Iterate through the Array here 


// Create the switch case statement here for the Operator 


// Update the boolean result here 




Console.WriteLine("Hello, World!");
