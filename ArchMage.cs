using System;

public class ArchMage : Mage
{
    private int ancientKnowledge;

    // Konstruktor default
    public ArchMage() : base()
    {
    }

    // Konstruktor berparameter
    public ArchMage(
        int ancientKnowledge,
        int spellPower,
        string id,
        string name,
        int basePower,
        string address)
        : base(spellPower, id, name, basePower, address)
    {
        this.ancientKnowledge = ancientKnowledge;
    }

    public void DisplayData()
    {
        base.DisplayData();

        Console.WriteLine("Ancient Knowledge : " + ancientKnowledge);
        Console.WriteLine(
            "Total Power       : " +
            (basePower + spellPower + ancientKnowledge)
        );
    }
}