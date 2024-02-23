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


Okay so basically I've worked out most of it. 

Now I need to handle the edge cases and handle negative numbers. 

I also, need to handle very large negative numbers. 

So it might require a very different approach. 


Okay so it would help if the number was positive to start with then 

when we have the multiple that is required we can take that number and turn it 

negative. 

Okay so let's say we have a very large number now that 


we have take the absolute value of the negative number. 


Then let's say we just do that same routine as before. 

I think it would be good to turn the while loop and the rest of 

the code after the while loop into a function. 

Then I can call that function in the if statement that checks if a 

number is negative. 

Don't worry about repeated code or not being able to 

create a function within codewars I'm not going for efficiency 

just yet I'm just trying to solve the problem. 


Okay so I'm thinking of another approach and this could very well 

work. 

What if I turned the number into a string and then 

turned that string into a char Array and then 

grabbed the last element of that char Array and stored 

it in a variable then 

turned that back into a number and then ran a sub-routine 

to see what number needs adding or subtracting to 

it in order for it to be a multiple of five. 


Okay so that sounds good. 

I just need to test it out. 



Okay so it seems with negative numbers we're always rounding down. 

So what I need to do is just work out the difference and 

then add it onto the negative number and then I should get a multiple 

of five. 


Okay so what I do is I take the end number and I subtract five from it. 

Then I should get a remainder. 

And this should be added onto the large negative number. 













































*/



// int input = 12;
int input = -413797; 

if(input == 0){
    Console.WriteLine("zero"); 
    
}
if(input == -5){

    Console.WriteLine("-5"); 
    

}

if(input < 0){


// Get the String value of the input 

String newInput = input.ToString();

    Console.WriteLine("this is the input converted to a string");
    Console.WriteLine(newInput);


    // Turn the String into a char Array 
    char[] chars = newInput.ToCharArray();

    // Now get the last character from the char Array. 
    int len = chars.Length;
    Console.WriteLine("this is the length of the char array");
    Console.WriteLine(len);


    // Now get the last character of the char Array and store it in a string 

    char lastChar = chars[len -1];

    Console.WriteLine("this is the last character of the Array");
    Console.WriteLine(lastChar);
    
    if(lastChar == '0' || lastChar == '5'){

        Console.WriteLine("We're return the number we've found a match");
        Console.WriteLine(input);
        
                    
                    
    }


    // Now turn the lastCharacter into a String. 
    String lastString = lastChar.ToString();


    Console.WriteLine("this is the last character turned into a string");
    Console.WriteLine(lastString);


    // Now turn the string into a number
    int lastNum = int.Parse(lastString);

    Console.WriteLine("this is the last number as an int");
    Console.WriteLine(lastNum);


    int difference = lastNum - 5;

    Console.WriteLine("this is the difference between 5 & lastNum");
    Console.WriteLine(difference);


    // Now add the difference to last Num; 

    int finalNum = lastNum + difference;

    Console.WriteLine("this is the final number");
    Console.WriteLine(finalNum);


    int returnValue = input + difference;

    Console.WriteLine("this is the return value");
    Console.WriteLine(returnValue); 
    


}

int mult = 0; 
// Create the while loop here 
while(input > mult){


    mult += 5;
    
    
    
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