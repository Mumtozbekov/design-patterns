using Prototype;

var original = new Sheep("Jolly", "Mountain Sheep");
Console.WriteLine(original.Name); // Jolly
Console.WriteLine(original.Category); // Mountain Sheep

var cloned = original.Clone();
cloned.Name = "Dolly";
Console.WriteLine(cloned.Name); // Dolly
Console.WriteLine(cloned.Category); // Mountain Sheep
Console.WriteLine(original.Name); // Jolly