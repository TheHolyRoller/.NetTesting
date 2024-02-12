// Add in the imports here 
using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;


/*

Okay so this is a bit harder than the usual 

challenges. 

First of all I need to work out a way of getting the 

right number into the right team. 

So I'm given an array of numbers and these 

numbers represent the weights of team members and 

are waiting in a row. 

There are two Rows of people and they all need to be 

processed and sent to the right team. 

Then their weights need to be added up and returned. 



The main task is to get the right team member into the right 
team. 

So the way it works is the first person in line goes to the 
first team and the second person in line goes to the 

second team and then third person inline goes to the first 
team and the fourth person inline goes to the second 
team and the fifth person in line goes to the first team. 

Okay so there's a pattern here is the person's number is 

odd they go to the odd number team and if the person's number 
is even they go to the even team which is team two. 

So if we had a counter variable that started at 1 and we incremented it by 
one every time we added a team member to a team then we could keep track of 
whether or not the person's number was odd or even. 

Then if the current counter variable is even then we send the team member to 
group two otherwise we send them to team one. 

Okay so basically we need to have a check to see if the number is even 
and if it is we send the team member to team two. 

And we don't need to check if the number is odd because we just send them 
to team one. 

Okay that sounds great. 

So I'll need to have a List for each team then I can just loop through each 
list convert the current into to an integer and then add it to a variable that 
will keep track of the weight of one of the teams and then I can 
convert that integer to a string and add it to the returned Array. 

Okay so let's work out how we're going to get the team member's weights and 
convert them to integers and then store them and then add up the value 
and then convert the value back to a string and then add that 
string value to an array and then return that array. 


Okay so it seems like I've worked out how to get the right team 
members into the right teams and now I just need to work out how 
to get the values from the Array and add them up and then return the Array 

with the right totals in the right order. 

Okay so first of all I'm actually given an integer Array so all I need to do is 
loop through that array implement the mechanism to ensure that the 
right element goes to the right variable total that stores the total weight 
for each team. 

Okay so basically all I need to do is loop through the integer array. 


Then using the mechanism add the integer value to the right variable 
that holds the total weight for that particular team and then 
create one Array. 

Convert the two integer variables to the String Equivalent and then 

add team one's variable to index zero and team two's variable to index 1. 

Then I just return that array. 

So it turns out I don't need to convert the variables into their String 
equivalents because the return type for the function is an integer array. 


Okay so just to recap I loop through the integer Array. 

I have the counter variable that keeps track of odd and even. 

I do a quick check to see if the current counter variable is even 
if it is I add the value to team two's Variable if it's not then I add the 

current item's value to team one's Variable. 

Then once those values have been added I add team one to index zero of the 
return array and I add team two to index one of the return Array and then 
I return the return Array with the total weight in integers for each 
team in the right index of the return array.

*/


// Create the input Array here 
int[] inputArray = { 39, 84, 74, 18, 59, 72, 35, 61 };

Console.WriteLine("this is the input Array");
Console.WriteLine(inputArray); 



// Create the return Array here 
int[] finalArray = new int[2];


// Create the value container for team one here 
int teamOne = 0;

int teamTwo = 0;


// Create the tracking variable here 

int tracker = 1; 


// Loop through the input Array here 

foreach(int elem in inputArray ){

    Console.WriteLine("this is the current tracker value");
    Console.WriteLine(tracker);

    Console.WriteLine("this is the current element");
    Console.WriteLine(elem); 
    
    
    // Only one check required 
    
    
    if(tracker % 2 == 0){

        teamTwo += elem;
        Console.WriteLine("this is the new value of team two");
        Console.WriteLine(teamTwo); 
        
        
        
        
    
    
    }
    else{

        teamOne += elem;
        Console.WriteLine("this is the new value of team one ");
        Console.WriteLine(teamTwo); 
    
    
    }

    Console.WriteLine("incrementing the tracker"); 
    tracker++; 

}


// Add teamOne to the first index of the return Array here 
finalArray[0] = teamOne;
Console.WriteLine("this is the team one total");
Console.WriteLine(teamOne); 


finalArray[1] = teamTwo;
Console.WriteLine("this is the team two total");
Console.WriteLine(teamTwo); 



Console.WriteLine("Hello World!"); 




