using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks.Dataflow;


/*

Okay so this is the problem that needs to be solved. 

First of all I'm give a string. 

This string consists of upper & lower case letters 
as well as numbers & characters. 

The task is to keep track of the number 
of upper case lower case numbers & characters there 
are in the string. 

Then those numbers are then placed into a list one by 

one. 

Okay so the order is uppercase letters then lower case letters and then 

numbers and then characters. 

That is the order the numbers should go into the array in. 


Okay so let's work out how we're going to keep track of the 

the occurrences of upper case letters. 

The first thing that comes to mind is a for loop. 

So turn the string into a character Array and then loop through the 

character Array and then check each character and if it's an uppercase 
letter and if it is increment a variable. 



One way of making sure that the right variable goes into the right place 
is by having a counter variable and then after adding the numbers into 
the first value of the counter variable we increment the counter variable 

then we have the other occurrence variable into the list using the 
current value of the counter variable and then we increment it. 

Okay so there's been a change of plans. 

To start with I can't actually just check if an element is a character. 

It seems as though C# is more light weight and so therefore I'll 

need to run each element through multiple different regex expressions. 

Okay so that's great. 


First of all I need to check if it's a capital letter and if not then 

I'll check if it's a letter and then I'll check if it's a number then a symbol. 

If any one of these checks matches then I'll increment the right counter 


variable. 

That way I can check if an element is uppercase and a letter instead 

of having false matches with letters that are uppercase but also letters. 

Okay so the way I'll do this is with multiple 

regex expressions and in the foreach loop I'll check each element to see if 
it matches up. 

So what I'll do is I'll create all the regex expressions 
and I'll create several different boolean variables and then I'll 


I'll assign the value of those boolean variables to whatever the result is 

given the current element. 

Then in my checks I'll check each boolean variable to see if it's true. 

And if one of them is true I'll make the necessary changes and increment 

the counter variable. 































*/


// Put the input string here 

String s = "bgA5<1d-tOwUZTS8yQ";

Console.WriteLine("this is the input string");
Console.WriteLine(s); 




// Now turn the string into a character Array. 

char[] chars = s.ToCharArray();

// Create the counter variables here 
int upperChar = 0;

int lowerChar = 0;

int num = 0;

int sym = 0;

int[] res = new int[4]; 



// Now loop through the character Array 

foreach(var elem in chars){

// Check to see if elem is a character 
if(Char.IsLetter(elem) && Char.IsUpper(elem)){

        upperChar++;
        Console.WriteLine("this is the new value of upperChar");
        Console.WriteLine(upperChar); 

}

if(Char.IsLetter(elem) && Char.IsLower(elem)){

        lowerChar++;
        Console.WriteLine("this is the new value of lower char");
        Console.WriteLine(lowerChar); 

}

if(Char.IsDigit(elem)){

        num++;
        Console.WriteLine("this is the new value of num");
        Console.WriteLine(num); 

}

if(Char.IsSymbol(elem) || Char.IsPunctuation(elem) || Char.IsSeparator(elem)){

       sym++;
        Console.WriteLine("this is the new value of sym");
        Console.WriteLine(sym);
        

}

else{

        Console.WriteLine("there were not matches"); 
        

}

}


// Now add each incremented variable to the Array; 

res[0] = upperChar;

res[1] = lowerChar;
res[2] = num;

res[3] = sym;

Console.WriteLine("this is the number of uppper chars");
Console.WriteLine(upperChar);

Console.WriteLine("this is the number of lower chars");
Console.WriteLine(lowerChar);

Console.WriteLine("this is the number of integers");
Console.WriteLine(num);


Console.WriteLine("this is the number of symbols");
Console.WriteLine(sym); 

foreach(var elem in res){

    Console.WriteLine("this is the current element of result Array");
    Console.WriteLine(elem); 

}



Console.WriteLine("Hello World!"); 