using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks.Dataflow;



/*

Okay so the task appears to be quite simple. 

The Task is to take a string an flip the case of the letters. 

So if one letter is uppercase then flip it to lower case. 

If one letter is lower case then change it to uppercase. 


Okay so the way I'm going to do this is I'm going to take the string. 


Then I'm going to turn it into a character Array. 

Then I'm going to loop through that character Array checking if each element is 
upper or lower case and I'm just going to flip the case of each one. 












*/


// Add in the string here 
String s = "Hello World";


char[] chars = s.ToCharArray();
List<char> list = new List<char>(); 


foreach(var elem in chars){


if(Char.IsUpper(elem)){


      char lower =  Char.ToLower(elem);
        list.Add(lower);

}

else if(Char.IsLower(elem)){

    char upper =  Char.ToUpper(elem);
        list.Add(upper); 
        

}


}

// Turn the character Array into a string here 

String res = new String(chars);


String result = String.Join("", list);
Console.WriteLine("this is the result");
Console.WriteLine(result); 


Console.WriteLine("this is the inverted string");
Console.WriteLine(res); 


Console.WriteLine("Hello World!"); 