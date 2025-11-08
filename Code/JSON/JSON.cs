/*
 * Date: 2024-06-15
 * Description: This C# program demonstrates JSON serialization and deserialization
 */
using System.Text.Json;

var people = new People
{
    Id = 1,
    Name = "Mario",
    Country = "México"
};

string json = JsonSerializer.Serialize(people);
Console.WriteLine(json);
People people2 = JsonSerializer.Deserialize<People>(json);
Console.WriteLine(people2.Name);

List<People> peopleList = new List<People>
{
    new People { Id = 1, Name = "Mario", Country = "México" },
    new People { Id = 2, Name = "Luigi", Country = "Italia" },
    new People { Id = 3, Name = "Peach", Country = "Mushroom Kingdom" }
};
string jsonList = JsonSerializer.Serialize(peopleList);
Console.WriteLine(jsonList);
List<People> peopleList2 = JsonSerializer.Deserialize<List<People>>(jsonList);
Console.WriteLine(peopleList2[0].Name);

public class People
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
}