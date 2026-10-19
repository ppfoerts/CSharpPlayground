Console.WriteLine("Hello, This is a character generator! To make it randomly create a character, give a name:");
string characterName = Console.ReadLine();

// Random Stats
var character = (Name: characterName, 
    strength : Random.Shared.Next(3, 18),
    dexterity : Random.Shared.Next(3, 18),
    constitution : Random.Shared.Next(3, 18),
    wisdom : Random.Shared.Next(3, 18),
    intelligence : Random.Shared.Next(3, 18),
    charisma : Random.Shared.Next(3, 18));


Console.WriteLine($"""
    Okay, {character.Name} has
    Str: {character.strength}
    Dex: {character.dexterity}
    Con: {character.constitution}
    Wis: {character.wisdom}
    Int: {character.intelligence}
    Cha: {character.charisma}
""");