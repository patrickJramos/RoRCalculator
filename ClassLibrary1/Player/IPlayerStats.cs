using System;
using System.Collections.Generic;
using System.Text;

namespace RoR.Player
{
    public interface IPlayerStats
    {
        float BaseDamage { get; set; }
        float CritChance { get; set; }
        float Luck { get; set; }
        float ProcCoeficcient { get; set; }
        float MaxHP { get; set; }
        float HpRegen { get; set; }
        IList<Action<IPlayer, float, Random>> OnHit {get;set;}

        float TotalDamageDealt { get; set; }
    }
}
