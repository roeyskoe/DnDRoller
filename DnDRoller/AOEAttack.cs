using System;

namespace DnDRoller;

public class AOEAttack : Attack
{
    public Save Save { get; set; }
    public int SaveLimit { get; set; }
    public AOEAttack(Dice d, int n, int plus, Save save, int saveLimit)
    {
        Dice = d;
        NDice = n;
        Plus = plus;
        Save = save;
        SaveLimit = saveLimit;
    }
    
    public override ThrowResult Throw(int targetAc = 0)
    {
        ThrowResult tr = new ThrowResult();

        tr.Damage = Throw(false);
        tr.Succeeded = true;
        tr.Save = Save;
        tr.SaveLimit = SaveLimit;

        return tr;
    }
}