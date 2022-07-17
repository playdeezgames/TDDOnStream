using EverCraftCs;

var character = new Character();

Console.Write("What is yer name? ");
character.Name = Console.ReadLine();

Console.WriteLine($"Yer Armor Class: {character.ArmorClass}");
Console.WriteLine($"Yer Hit Points: {character.HitPoints}");

Console.ReadLine();