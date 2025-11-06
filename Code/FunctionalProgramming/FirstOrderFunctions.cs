/*
    Description: This C# program demonstrates the use of First Order
    functions.
 */
Action<string> show = message => Console.WriteLine(message);
List<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
// We can characterize even numbers, numbers bigger than 5 or any other
var pairs = Filter(list, number => number % 2 == 0);
var biggestThan5 = Filter(list, number => number > 5);
Action<List<int>> printList = numbers =>
{
    foreach (var number in numbers)
    {
        show(number.ToString());
    }
};
printList(pairs);
printList(biggestThan5);
// Zipping two lists together
foreach (var (a, b) in pairs.Zip(biggestThan5))
    show($"{a}, {b}");
// First-Order function using Func delegate
List<int> Filter(List<int> numbers, Func<int, bool> condition)
{ 
    List<int> result = new List<int>();

    foreach (var number in numbers)
    {
        if (condition(number))
        {
            result.Add(number);
        }
    }

    return result;
}
