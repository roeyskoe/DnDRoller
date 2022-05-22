using System;

namespace DnDRoller;

public class DirectAttack : Attack
{
    public int ToHitPlus { get; set; }
    public DirectAttack(Dice d, int n, int plus, int toHit)
    {
        Dice = d;
        NDice = n;
        Plus = plus;
        ToHitPlus = toHit;
    }
    
    public override ThrowResult Throw(int targetAc = 0)
    {
        ThrowResult tr = new ThrowResult();
        tr.Succeeded = false;
        int throwRes = Random.Shared.Next(1, 21);
        if (throwRes + ToHitPlus >= targetAc)
        {
            bool crit = throwRes == 20;
            tr.Damage = Throw(crit);
            tr.Crit = crit;
            tr.Succeeded = true;
        }

        tr.Hit = throwRes + ToHitPlus;

        return tr;
    }
    
}