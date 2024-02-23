using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks.Dataflow;

/*




*/



int num = 4843000;


// Now turn the integer into a string 
String strNum = num.ToString();


// turn the string into a char Array 
char[] charArr = strNum.ToCharArray();

List<char> list = new List<char>(); 

bool notZero = true; 

// Now loop through the character Array
for(int i = charArr.Length - 1; i > -1; i--){
 
 if(!notZero){
                
                list.Add(charArr[i]);

        Console.WriteLine("the character is not zero");
        Console.WriteLine(charArr[i]); 
        
                
}


 else if(charArr[i] == '0' && notZero ){

                Console.WriteLine("the character is a zero");
                Console.WriteLine(charArr[i]); 
}


if(charArr[i] != '0' && notZero){
                
                notZero = false;
                list.Add(charArr[i]); 
                
}

}

Console.WriteLine("this is the resulting list");
Console.WriteLine(list);

String res = String.Join(", ", list); 


Console.WriteLine("this is the altered string");
Console.WriteLine(res); 


Console.WriteLine("Hello World!"); 