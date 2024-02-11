// Add in the imports here 
using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;




/*

Okay so this is quite a simple Kata. 

Basically what I need to do is remove one and only 
one exclamation mark from the end of a string. 

This needs to be truly at the end of a string 
if there is an exclamation mark before the end of a string 
it must not be removed. 

If there is an exclamation mark after one word in a string 
and there is another word after that and 
it does not contain an exclamation mark then no 

exclamation mark is removed. 

Okay so it also looks like the exclamation mark 

must be right at the end of a string. 

So if it's not the last character of a string then 

no exclamation mark needs to be removed. 

So basically I need to check the last character of a 

string and see if it matches an exclamation mark. 

If it does then it should be removed and if not 

nothing should be done. 

Okay so that sounds good so the basic tasks are creating the 
input string and then turning that string into a char 
array and then creating a regex expression for the exclamation mark 
and then accessing the last element of the char Array and then if it matches 
the regex removing it. 

Okay so that sounds good. 






*/

String input = "Hi!!";

Console.WriteLine("this is the input");
Console.WriteLine(input); 



// Now convert the string into a character Array 

char[] arr = input.ToCharArray();

Console.WriteLine("this is the character array");
Console.WriteLine(arr);


// Create the regex expression here 
char mark = '!'; 



char lastElem = arr[arr.Length - 1];

Console.WriteLine("this is the last element");
Console.WriteLine(lastElem); 

if(lastElem == mark){

    Console.WriteLine("they are alike");
    Console.WriteLine("this is the last elem");
    Console.WriteLine(lastElem);
    Console.WriteLine("this is the mark");
    Console.WriteLine(mark);
    
    
    input = input.Remove(input.Length - 1); 
}

// Log the updated string to the console here 
Console.WriteLine("this is the updated string");
Console.WriteLine(input); 


Console.WriteLine("Hello World!"); 




