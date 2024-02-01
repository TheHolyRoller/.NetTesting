// Add in the imports here 
using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;



/* 

Okay so basically all I need to do is 

check the value of the double that is 

passed into a function. 

If it meets a certain threshold then 

I want to return a certain character. 

So I'll need to start with a base chase and then I 

could use a series of else if statements or I could 

use a switch statement. 

I think I'll go with switch because I need some practice in 
that. 

Okay so first of all. 






*/


// Create the double variables here 

double A = 0.9;

double B = 0.8;

double C = 0.7; 

double D = 0.6;


// Create the main variable that will be used as 
// a Test case

double grade = A;

Console.WriteLine("this is the grade that has been passed down");
Console.WriteLine(grade);

Type type = grade.GetType(); 

Console.WriteLine("this is the type of grade"); 
Console.WriteLine(type.Name); 


if(grade >= 0.9){

        Console.WriteLine("Congratulations you acheived an A"); 
        

}

else if(grade >= 0.8){

        Console.WriteLine("You acheived a B"); 
        


}

else if(grade >= 0.7){

        Console.WriteLine("YOU SCORED A C"); 
        


}

else if(grade >= 0.6){

        Console.WriteLine("you scored a D work harder"); 
        

}

else{


        Console.WriteLine("You need to upgrade your skills"); 
        

}



Console.WriteLine("Hello, World!");
