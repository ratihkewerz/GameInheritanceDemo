using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== DEFAULT WARRIOR ===");

        Warrior defaultWarrior = new Warrior();
        defaultWarrior.DisplayData();

        Console.WriteLine();

        Console.WriteLine("=== WARRIOR BERPAMETER ===");

        Warrior warrior = new Warrior(
            "W001",
            "Budi",
            100,
            "Wonosobo",
            50
        );

        warrior.DisplayData();

        Console.WriteLine();

        Console.WriteLine("=== ARCHMAGE ===");

        ArchMage archMage = new ArchMage(
            80,
            70,
            "A001",
            "Andi",
            100,
            "Wonosobo"
        );

        archMage.DisplayData();

        Console.ReadKey();
    }
}
