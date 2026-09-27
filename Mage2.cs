using System;

public class Mage : Character
{
    protected int spellPower;

    
    public Mage() : base()
    {
    }

    
    public Mage(
        int spellPower,
        string id,
        string name,
        int basePower,
        string address)
        : base(id, name, basePower, address)
    {
        this.spellPower = spellPower;
    }

    public void DisplayData()
    {
        base.DisplayBaseData();

        Console.WriteLine("Spell Power  : " + spellPower);
        Console.WriteLine("Total Power  : " + (basePower + spellPower));
    }
}
