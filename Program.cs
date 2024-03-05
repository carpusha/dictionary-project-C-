using System.Text.Json;

List<int> list = new List<int> { 1, 2, 3 };
Dictionary<int, string> dictionary = new Dictionary<int, string>()
{
            { 1, "banana" },
            { 2, "apple" },
            { 3, "cucumber" },
};
Dictionary<string, int> newDictionary = new Dictionary<string, int>();
foreach (var item in dictionary)
{
    newDictionary.Add(item.Value, item.Key);
}

string json = JsonSerializer.Serialize(newDictionary);
Console.WriteLine(json);


Console.ReadKey();
