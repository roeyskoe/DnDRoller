using System;
using System.Collections.Generic;

namespace DnDRoller;

public class Monster
{
    public int Hp { get; set; }

    private int maxhp;

    public int MaxHp
    {
        get => maxhp;
        set
        {
            int hpDiff = value - MaxHp;
            maxhp = value;
            Hp += hpDiff;
        }
    }

    public List<Attack> Attacks { get; set; } = new List<Attack>();

    public Monster()
    {
        MaxHp = 50;
    }
}