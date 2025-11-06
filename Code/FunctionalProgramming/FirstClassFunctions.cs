/*
    Description: This C# program demonstrates the use of functional 
    programming concepts such as higher-order functions, lambda expressions,
    and First-Class Functions.
 */
// Assigned as argument
var now = PureTomorrow;
Console.WriteLine(now
    (new DateTime(2025, 12, 21, 0, 0, 0, 0)
));
DateTime PureTomorrow(DateTime dt)
{
    return dt.AddDays(1);
}
// Example of a lambda expression as a First-Class Function
Func<int,int, int> add = (a, b) => a + b;
Console.WriteLine(add(2, 3));

// Passed them as arguments
Repeat(3, i =>
    Console.WriteLine($"Iteration {i + 1}")
);
void Repeat(int n, Action<int> action)
{
    for (int i = 0; i < n; i++) 
        action(i);
}

// Returned from other functions
int value = 7;
Func<int, int> MakeAdder(int x)
{
    return y => x + y; // Closure
}
var add10 = MakeAdder(value);
Console.WriteLine(add10(value));
Console.WriteLine(add10(value));
Console.WriteLine(MakeAdder(6)(15));
Console.WriteLine(value);

// Storing in data structures 
var operations = 
    new Dictionary<string, Func<int, int, int>>
{
    { "add", (a, b) => a + b },
    { "mul", (a, b) => a * b }
};
Console.WriteLine(operations["add"](4, 5)); // 9
Console.WriteLine(operations["mul"](4, 5)); // 20
Console.WriteLine("Adding: " + operations["add"](4, 5)); // 9
Console.WriteLine("Adding: " + operations["add"](4, 5)); // 9
