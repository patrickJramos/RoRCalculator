using System;
using System.Collections.Generic;
using System.Text;

namespace RoRImplementation.Player.Players.Commando
{
    class CommandoStats : PlayerStats
    {
        public override float BaseDamage { get; set; } = 10;
        public override float ProcCoeficcient { get; set; } = 1;
        public override float MaxHP { get; set; } = 100;
        public override float HpRegen { get; set; } = 1;
    }
}
