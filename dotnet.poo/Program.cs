using dotnet.poo.src.Entities;
using static System.Console;

{
    Knight knight = new Knight ("Maléficos", 99, "evil");
    BlackWizard blackWizard = new BlackWizard ("Papus", 99, "Black Wizard");
    Wizard wizard = new Wizard ("Jennita", 73, "White Wizard");
    Ninja ninja = new Ninja ("Momochi", 73, "Speed");

    var Hero = new List<string>{"maléficos", "popus", "jennita", "momochi"};
    foreach(var hero in Hero)
    {
        WriteLine("Herói, " + hero.ToUpper());
    }
    WriteLine("\n");
    WriteLine(wizard.Attack(1));
    WriteLine(knight.Attack(2));
    WriteLine(ninja.Attack(10));
    WriteLine(blackWizard.Attack(10));

}