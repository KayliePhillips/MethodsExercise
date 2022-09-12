//C# Method Exercise from TrueCoders portal
//Record user input for Name, Favorite Color, Favorite Animal, Favorite Number
// Part c -- *Bonus* Abstract away the code into methods and call them in your main
using MethodExercise;
Console.WriteLine("----------------------------Step 5c----------------------------------");

Method.Exercise1();


Console.WriteLine("----------------------------Step 6----------------------------------");
//Declare 5 methods: 1 Add method, 1 subtract method, 1 multiply method, 1 divide method, 1 modulus method.

//Add
Console.Write($"Addition answer: ");
Console.WriteLine(Method.Add(5, 5));


//Subtract
Console.Write($"Subtraction answer: ");
Console.WriteLine(Method.Subtract(10, 5, 4));

//Multiply
Console.Write($"Multiplication answer: ");
Console.WriteLine(Method.Multiply(3, 5));

//Divide
Console.Write($"Division answer: ");
Console.WriteLine(Method.Divide(20, 3));

//Modulus
Console.Write($"Modulus answer: ");
Console.WriteLine(Method.Modulus(42, 5));


Console.WriteLine("----------------------------Bonus Step 8----------------------------------");
//Change the functions to us the params keyword to support a range of arguements.
//Add() methhod that takes as many arguements as needed

//a. Sum(2,4) would return 6.  
Console.Write($"Sum(2,4) answer: ");
Console.WriteLine(Method.AddParams(2,4));

//b. Sum (2,4,6) would return 12.
Console.Write($"Sum(2,4,6) answer: ");
Console.WriteLine(Method.AddParams(2, 4, 6));

//c. Sum (1,1,1,1,1) would return 5
Console.Write($"Sum (1,1,1,1,1) answer: ");
Console.WriteLine(Method.AddParams(1, 1, 1, 1, 1));


