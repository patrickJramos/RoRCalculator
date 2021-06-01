using RoR;
using RoR.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoRImplementation.Player
{
    abstract class PlayerStats : IPlayerStats
    {
        abstract public float BaseDamage { get; set; }
        public float CritChance { get; set; } = 0.01F;
        public float Luck { get; set; } = 0;
        abstract public float ProcCoeficcient { get; set; }
        abstract public float MaxHP { get; set; }
        abstract public float HpRegen { get; set; }
        public IList<Action<IPlayer, float, Random>> OnHit { get; set; } = new List<Action<IPlayer, float, Random>>();
        public float TotalDamageDealt { get; set; } = 0;
    }
}
