// See https://aka.ms/new-console-template for more information
using criaturas;
using criaturas.monstros;

Console.WriteLine("Hello, World!");

Criatura blackKnight = new BlackKnight();
Sorcerer player = new Sorcerer("Ziwe");

Console.WriteLine(blackKnight);
Console.WriteLine(player);

player.SubirNivel();
Console.WriteLine(" ");
Console.WriteLine(player);
