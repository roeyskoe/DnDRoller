using System;
using System.Collections.Generic;

namespace DnDRoller;

public class Monster
{
    public int Hp { get; set; }
    public int MaxHp { get; set; }
    public List<Attack> Attacks { get; set; } = new List<Attack>();
}