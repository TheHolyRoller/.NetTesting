using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;

/*

Okay so it seems as though the task 

is pretty simple I just need to return true 

if the animal is bringing a disk that has a name with it's 
starting and ending letters the same as the starting and ending letters of 
their name 

So basically I'm given the name of an animal in a string and 
I'm given the name of a dish in a string and I need to determine if 

the starting and ending letters match the starting and ending letters 

of the dish. 

Okay so this should be quite simple. 

I'll turn both the animal name and the dish name into character Arrays 

Then I'll take the first and last character from the Animal Name and the 
first and last character from the dish name. 

I'll return true if they match up and false if they don't. 


*/


// Create the input animal name here 
string beast = "great blue heron";

string dish = "garlic naan";


// Turn the names to char Arrays here 
char[] beastArray = beast.ToCharArray();

char[] dishArray = dish.ToCharArray();


// Capture the first element of beastArray here 
char beastFirst = beastArray[0];

char beastLast = beastArray[beastArray.Length - 1];


char dishFirst = dishArray[0];
char dishLast = dishArray[dishArray.Length - 1]; 



if(beastFirst == dishFirst && beastLast == dishLast){


    Console.WriteLine("this is the first char of Beast name");
    Console.WriteLine(beastFirst);

    Console.WriteLine("this is the first char of dish");
    Console.WriteLine(dishFirst);


    Console.WriteLine("this is the last char of beast");
    Console.WriteLine(beastLast);
    Console.WriteLine("this is the last char of dish");
    Console.WriteLine(dishLast); 
    
    Console.WriteLine("they match up!"); 
        
        


}

else{


    Console.WriteLine("they don't match"); 
    

}







Console.WriteLine("Hello World!"); 