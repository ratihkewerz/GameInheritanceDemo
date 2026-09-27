using System;

public class Warrior : Character
{
    private int bonus;

    
    public Warrior() : base()
    {
    }

    
    public Warrior(string id, string name, int basePower, string address, int bonus)
        : base(id, name, basePower, address)
    {
        this.bonus = bonus;
    }

    public void DisplayData()
    {
        base.DisplayBaseData();

        Console.WriteLine("Bonus        : " + bonus);
        Console.WriteLine("Total Power  : " + (basePower + bonus));
    }
}
