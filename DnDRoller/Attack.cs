using System;

namespace DnDRoller;

public abstract class Attack
{
    public Dice Dice { get; set; }
    public int NDice { get; set; }
    public int Plus { get; set; }

    public int Throw(bool crit)
    {
        int sum = 0;
        int cr = crit ? 2 : 1;
        for (int i = 0; i < NDice * cr; i++)
        {
            sum += Random.Shared.Next(1, (int) Dice);
        }
        
        sum += Plus;
        return sum;
    }

    public abstract ThrowResult Throw(int targetAc = 0);
}