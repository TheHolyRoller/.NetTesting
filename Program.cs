using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;

/*

Okay so this seems like a pretty simple 

problem. 

I'm given three arguments. 

The first argument is is a boolean 
variable which is true or false. 

And then the other two are functions. 

Now if the boolean variable is false then 

the second function is called. 

If the boolean variable is true then 
the first function is called. 


Okay so pretty simple. 






*/



bool condition = true; 


 static void Run(){

        Console.WriteLine("the boolean value was true"); 
        


}


static void False(){

        Console.WriteLine("the boolean value was false"); 
        


}


if(condition){

        Run(); 
        

}

else{

        False(); 
        

}


Console.WriteLine("Hello World!"); 