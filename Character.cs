using System;

public class Character
{
    protected string characterID;
    protected string name;
    protected int basePower;
    protected string address;

    // Konstruktor default
    public Character()
    {
    }

    // Konstruktor berparameter
    public Character(string characterID, string name, int basePower, string address)
    {
        this.characterID = characterID;
        this.name = name;
        this.basePower = basePower;
        this.address = address;
    }

    public void DisplayBaseData()
    {
        Console.WriteLine("Character ID : " + characterID);
        Console.WriteLine("Name         : " + name);
        Console.WriteLine("Base Power   : " + basePower);
        Console.WriteLine("Address      : " + address);
    }
}