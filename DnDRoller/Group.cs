using System.Collections.Generic;

namespace DnDRoller;

/// <summary>
/// A group of similar monsters
/// </summary>
public class Group
{
    public List<Attack> Attacks { get; }

    public List<Monster> Monsters { get; } = new List<Monster>();

    public Group()
    {
        Attacks = new List<Attack>();
        Attacks.Add(new DirectAttack(Dice.d4, 1, 0, 10));
        Monster m = new Monster();
        m.Attacks = Attacks;
        Monsters.Add(m);
    }
    
    public Group(int n, List<Attack> attacks)
    {
        Attacks = attacks;
        for (int i = 0; i < n; i++)
        {
            Monster m = new Monster();
            m.Attacks = attacks;
            Monsters.Add(m);
        }
    }

    public void AddMonster()
    {
        Monster m = new Monster();
        m.Attacks = Attacks;
        Monsters.Add(m);
    }

    public List<ThrowResult> Attack(int targetAc, Attack attack)
    {
        List<ThrowResult> results = new List<ThrowResult>();

        foreach (var m in Monsters)
        {
            results.Add(attack.Throw(targetAc));
        }
        
        return results;
    }
}