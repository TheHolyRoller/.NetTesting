using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;



/*

Okay so it seems like the task is to input purging. 


So I'm given a url which is in the string format and 

I need to purge all the content after the Hashtag symbol. 

I also need to remove the hashtag symbol. 

Okay so that's good now I just need to figure out how to 

take all the characters including the hashtag and remove it from the 

string. 

So I could have a if else statement that checks for the 

hashtag symbol in the string. Then what I could do then is trigger the 

code in the if statement. This code in the if statement would toggle a 

boolean variable. The if statement would check if the character 
is a hashtag symbol and it would also check if the boolean variable is true. 

So that the code in the if statement would run if the character was a 

hashtag symbol or if the boolean variable is set to true. 

Now that the code in the if statement has been run and set the boolean 
variable to true then the if statement will always run at and after the 

hashtag character. 


Okay so that sounds good and if there is no hashtag character then 

the else statement will always run and the code will complete. 


Okay but first of all you need a string input. 

Then you need to turn the string into a character Array. 


Then you need to loop through the character Array. 

Then you need a way of modifying that character Array. 



Okay so there's been a bit of a change of plans. 

Instead of removing something from the character Array. 

What I'm going to do is add everything up to the point of the hashtag 

into a list and then I'm going to turn that list of characters into a 

new string and then I'm going to return that new string. 


Okay so I'll need the string input. 

Then I'll need a char type list. 

Then I'll need to turn that string into a character Array so I'll need a 
character Array. 

Then I'll need to loop through that character Array and I check if the 

character is a hashtag if it's not then I'll add the character to the list 
if it is then I'll break and return then convert the list into a 

string and then return that string. 



*/

String url = "www.codewars.com#about";


Console.WriteLine("this is the url");
Console.WriteLine(url); 



List<char> list = new List<char>(); 




char[] chars = url.ToCharArray();

Console.WriteLine("this is the chars Array");
Console.WriteLine(chars); 


foreach(var elem in chars){

// Now check if the elem is a hashtag. 
if(elem != '#'){


        // Add elem to the list 
        Console.WriteLine("this is the element being added");
        Console.WriteLine(elem); 
        
        list.Add(elem); 
        

}

else{

        Console.WriteLine("breaking out of the loop"); 
        break; 
        

}




}

// Turn the list into a string here 

// Convert the List to a char Array here 
String value = String.Join("", list);

Console.WriteLine("this is the returned string");
Console.WriteLine(value); 




// Return the new string here 







Console.WriteLine("Hello World!"); 