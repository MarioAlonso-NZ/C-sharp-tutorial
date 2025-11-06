/*
    Description: This C# program demonstrates the use of Delegates.
*/

// Using Action delegate
Action<string> greet = 
    name => Console.WriteLine($"Hello, {name}!");
greet("Alice is " + 5);
Action<int, int> sum = (a, b) => Console.WriteLine(a + b);
sum(2, 5);
Action<string> show = Console.WriteLine;
show("Delegates C#");

// Using Func delegate
Func<int, int, int> multiply = (a, b) => a * b;
Console.WriteLine(multiply(3, 4));

// Using Predicate delegate
Predicate<int> isEven = n => n % 2 == 0; // Lambda expression
Console.WriteLine(isEven(4));
