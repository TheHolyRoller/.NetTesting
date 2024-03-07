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

char[] returnArray = new char[s.Length]; 
      StringBuilder sb = new StringBuilder();

for(int i = 0; i < s.Length - 1; i++){


if(Char.IsUpper(chars[i])){
        
        sb.Append(Char.ToLower(chars[i]));
          continue;

}

 sb.Append(Char.ToUpper(chars[i]));


}


Console.WriteLine("this should work");
Console.WriteLine("this is the returned String"); 
Console.WriteLine(sb.ToString()); 


// Console.WriteLine("Hello World!"); 