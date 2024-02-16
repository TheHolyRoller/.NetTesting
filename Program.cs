using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;

/*

    
    if(Char.isLetter(a) && Char.isLetter(b) && Char.isUpper(a) && Char.isUpper(b)){

*/

char a = 'a';
char b = 'B';

bool isLetterA = Char.IsLetter(a);
bool isLetterB = Char.IsLetter(b);

bool isUpperA = Char.IsUpper(a);
bool isUpperB = Char.IsUpper(b); 


if(!isLetterA || !isLetterB){


    Console.WriteLine("one of the characters is not a letter"); 
    

}

else if(isLetterA && isLetterB && isUpperA && isUpperB){


    Console.WriteLine("They are both letters and uppercase"); 

}

if(isLetterA && isLetterB && !isUpperA && !isUpperB){


}



if(isLetterA && isLetterB && !isUpperA || !isUpperB){

    Console.WriteLine("Both characters are letters but not uppercase"); 

}








Console.WriteLine("Hello World!"); 