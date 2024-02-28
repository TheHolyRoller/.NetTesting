using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks.Dataflow;


/*



Okay so it seems like the task is pretty simple. 


I need to purge the numbers from a string. 

So if it's just a string of numbers then I don't do anything. 

But if there is a number then you remove it. 


Okay so basically I need a way of determining if a string contains any letters. 

Then if it doesn't I just return that string. 

If it does however I just convert the string to a char Array and 

then loop through the char array and add all letters to a list. 

Then convert that list to a string and return that String. 













*/ 


string s = "aa1bb2cc3dd"; 
bool containsLetters = s.Any(char.IsLetter);
List<char> list = new List<char>(); 


if(containsLetters){


    // Now extract the numbers from the text 
    char[] chars = s.ToCharArray(); 
    
    foreach(var elem in chars){
    
    if(Char.IsDigit(elem)){

            list.Add(elem); 

    }
    
    else{
    
    Console.WriteLine("we found a character"); 
    
    }
    
    
    }



    String res = String.Join("", list); 


    Console.WriteLine("this is the filtered number");
    Console.WriteLine(res); 

}

else{
    Console.WriteLine(s); 
    
}












Console.WriteLine("Hello World!"); 