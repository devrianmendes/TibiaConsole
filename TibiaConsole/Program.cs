// See https://aka.ms/new-console-template for more information

using personagens;
using monstros;

Console.WriteLine("Bem-vindo ao Tibia.");
Console.Write("Qual será o nome do seu personagem? ");
string name = Console.ReadLine();

Console.WriteLine($"Belo nome! {name}, a partir de agora você fará parte da guilda dos cavaleiros.");
Console.WriteLine("Seu objetivo aqui em Rookgard é atingir o nível 8.");
Console.WriteLine(" ");

Cavaleiro player = new Cavaleiro(name);
List<Monstro> monstrosVivos = new List<Monstro>();

Console.WriteLine("Estes são os atributos do seu personagem: ");
Console.WriteLine(player);


Rato rato = new Rato();
monstrosVivos.Add(rato);

Console.WriteLine(rato);
Console.WriteLine(monstrosVivos.Count);

Console.WriteLine(rato);


rato.Morrer();
monstrosVivos.Remove(rato);
Console.WriteLine(monstrosVivos.Count);