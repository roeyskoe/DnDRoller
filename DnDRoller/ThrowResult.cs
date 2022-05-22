using System;

namespace DnDRoller;

public class ThrowResult
{
    public bool Succeeded { get; set; }
    public bool Crit { get; set; }
    public int Hit { get; set; }
    public int Damage { get; set; }
    public Save Save { get; set; }
    public int SaveLimit { get; set; }

    public void PrettyPrint()
    {
        Console.ForegroundColor = Succeeded ? ConsoleColor.Green : ConsoleColor.Red;

        if (Crit) Console.Write("🌟");
        if (Hit == 0)
        {
            Console.WriteLine($"Aoe: {Save} {SaveLimit}, Damage: {Damage}");
        }
        else
        {
            Console.WriteLine($"Hit: {Hit} Damage: {Damage}");
        }
    }

    public override string ToString()
    {
        return $"Suc: {Succeeded} Crit: {Crit} Hit: {Hit} Damage: {Damage}";
    }
}