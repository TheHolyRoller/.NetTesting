// Add in the imports here 
using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;


/*


*/

// Create the 2D Array here 
int[,] matrix = new int[3, 5] {
    {1,2,3,4,5},
    {5,6,7,8,9},
    {20,21,34,56,100}
};


Console.WriteLine("this is the 2D Array");
Console.WriteLine(matrix);

Console.WriteLine("this is the type of the 2D Array");
Console.WriteLine(matrix.GetType().Name); 


int len = matrix.GetLength(1);

Console.WriteLine("this is the length of the matrix");
Console.WriteLine(len);


// Create the min variable here 
int min = 10000;

// Create the total min variable here 
int totalMin = 0;

int counter = 1;

Console.WriteLine("this is the first value of an element in matrix");
Console.WriteLine(matrix[1,1]); 

for(int i = 0; i < matrix.GetLength(0); i++){

    Console.WriteLine("this is the value of i in the first loop");
    Console.WriteLine(i); 

for(int j = 0; j < matrix.GetLength(1); j++){

        // Find the min here 

        Console.WriteLine("this is the current item");
        Console.WriteLine(j);
        Console.WriteLine("this is the current tracker");
        Console.WriteLine(counter);

        
        
        if(matrix[i, j] < min){

            Console.WriteLine("this is the value of min before being updated");
            Console.WriteLine(min);
            Console.WriteLine("this is the value of j updating min");
            Console.WriteLine(matrix[i, j]);
            
            min = matrix[i, j];
            Console.WriteLine("this is the new value of min after being updated");
            Console.WriteLine(min); 
            
        }
        
        if(counter % len == 0){
            
            Console.WriteLine("We have just come to the end of one Array");
            Console.WriteLine("this is the counter");
            Console.WriteLine(counter); 
            
            totalMin += min;

            Console.WriteLine("this is the current min");
            Console.WriteLine(min); 

            Console.WriteLine("this is the new totalMin");
            Console.WriteLine(totalMin); 

            // Reset min here 
            min = 1000;

            Console.WriteLine("min has just been reset");
            Console.WriteLine("this is the new value of the current min");
            Console.WriteLine(min); 
        
        }


        counter++; 
}

}


Console.WriteLine("Hello World!"); 