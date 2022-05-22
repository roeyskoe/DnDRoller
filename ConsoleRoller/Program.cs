using System;
using System.Collections.Generic;
using DnDRoller;

List<Attack> attacks = new List<Attack>();
attacks.Add(new DirectAttack(Dice.d8, 4, 5, 5));
attacks.Add(new DirectAttack(Dice.d4, 2, 1, 5));
attacks.Add(new AOEAttack(Dice.d4, 2, 1, Save.Dexterity, 11));

Group group = new Group(1, attacks);

while (Console.ReadKey().KeyChar != 'a')
{
    Console.WriteLine("=================");
    List<ThrowResult> results = group.Attack(14, attacks[Random.Shared.Next(0,3)]);

    foreach (var res in results)
    {
        res.PrettyPrint();
    }
    Console.ResetColor();
}
