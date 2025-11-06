/*
 * Description: Demonstrates a pure function that does not modify its input
 * besides beign side-effect free, that is, deterministic.
 */
DateTime date = new DateTime(2025, 12, 21, 0, 0, 0, 0);

Console.WriteLine($"Before PureTomorrow {date}");
Console.WriteLine(PureTomorrow(date));
Console.WriteLine($"After PureTomorrow {date}");
DateTime PureTomorrow(DateTime dt) => dt.AddDays(1);

// Demonstrate that structs are passed by value (copied) to methods
// 4. Create the original point
MyPoint originalPoint = new MyPoint { X = 10, Y = 5 };
// 5. Pass it to the method. C# makes a copy.
MutatePoint(originalPoint);
// 6. Check the original. It is unchanged!
Console.WriteLine($"Outside method: {originalPoint.X}, {originalPoint.Y}"); // Output: 10, 5
// 2. This method receives a COPY of the point
void MutatePoint(MyPoint p)
{
    // 3. This changes the COPY, not the original
    p.X = 100;
    Console.WriteLine($"Inside method: {p.X}, {p.Y}"); // Output: 100, 5
}
// 1. Define a struct
public struct MyPoint
{
    public int X;
    public int Y;
}
