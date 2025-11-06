/*
    Description: This C# program demonstrates the use of First Order
    functions.
 */
// Use of Action delegate
Action<string> show = message => Console.WriteLine(message);
Action<List<int>> printList = numbers =>
{
    foreach (var number in numbers)
    {
        show(number.ToString());
    }
};
// Use of Predicate delegate
Predicate<int> isEven = number => number % 2 == 0;
Predicate<int> isBiggerThan5 = number => number > 5;

List<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
var pairs = Filter(list, isEven);
var biggestThan5 = Filter(list, isBiggerThan5);
printList(pairs);
printList(biggestThan5);
// First-Order function using Func delegate
List<int> Filter(List<int> numbers, Predicate<int> condition)
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
