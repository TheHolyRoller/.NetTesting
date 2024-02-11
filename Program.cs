// Add in the imports here 
using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;



/*
Okay so I'm given an input string 

and I need to return the length of that string 

but I also need to return the number of letters 

in that string that should now be there. 

So I'm thinking I need to use some sort of regex pattern 

in order to match up any of the letters in the string 

with the letters that should not be in the string. 

Okay so basically what I think would be a good start is to 

turn the string into a char array and then loop through that 
char array and then check each char in that char array and see if it matches the 

regex expression for the letters that should not be in there and if they 

are in there then a counter variable is incremented each time. 

This counter variable will be incremented each time there is a wrong 
character in the string and thus will keep track of all the errors in the 
string. 

So basically at the end I can print out the counter variable along with the length 

of the control string and see if it matches up with the test on code wars. 

Okay so that sounds great. First of all let's start with the input string. 

Then I'll get going on making the regex expression. 

Okay so the main bulk of the program is finished now let's just work out how 

I'm going to properly return the a string with the number of mistakes as 
the numerator and the length of the string as the denominator. 

Okay so first of all. I need to get both numbers as integers and then I need to use 

string interpolation and string concatenation in order to create one 

main string that I'll return. 

Okay so I'll create the integers now and then I'll work out how to turn them into strings. 
Then I'll work out how to concatenate the two strings together with the 
slash symbol that they need. 






*/



// Put your program code here 


// Create the Input String here 

String controlInput = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";



// Create the regex expression here 

String regex = "[o-zO-Z]";


// Create the counter variable here 

int mistakes = 0;

// Turn the String into a character Array here 
char[] charArray = controlInput.ToCharArray(); 


// Create an Array that holds all the matches from the character Array using the regex 
// Expression here and then I can loop through that Array later 
        MatchCollection matches = Regex.Matches(controlInput, regex);


// Loop through the Char Array Using the Matches Type and Record the Number of Mistakes 
// Increment the counter variable each loop since using the Matches collection the loop 
// Will only iterate over an element that is a match in the character Array. 

foreach(Match match in matches){

    mistakes++;
    Console.WriteLine("A Mistake was found");
    Console.WriteLine("this is the match that was found");
    Console.WriteLine(match); 
    

}

Console.WriteLine("this is the final amount of mistakes"); 

Console.WriteLine(mistakes);

// Get the length of the input string here and save it as an integer 
int len = controlInput.Length;

Console.WriteLine("this is the length of the control input string");
Console.WriteLine(len);

// Now turn the number of mistakes and the length of the string into a string here 
 String mist = mistakes.ToString();
Console.WriteLine("this is the number of mistakes converted to a string");
Console.WriteLine(mist);

// Now Turn the length into a string 
string strLen = len.ToString();

Console.WriteLine("this is the length converted to a string");
Console.WriteLine(strLen);


// Now concatenate the strings 
String res = mist + "/" + strLen;

Console.WriteLine("this is the final concatenated String");
Console.WriteLine(res); 

Console.WriteLine("Hello World!"); 




