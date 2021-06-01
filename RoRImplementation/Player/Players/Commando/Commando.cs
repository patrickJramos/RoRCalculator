using System;
using System.Collections.Generic;
using System.Text;
using RoR;
using RoR.Player;
using RoRImplementation.Player.Inventory;
using RoRImplementation.Player.Players.Commando.Skills;

namespace RoRImplementation.Player.Players.Commando
{
    public class Commando : Player
    {
        public override IPlayerStats Stats { get; set; } = new CommandoStats();
        public override IPlayerInventory Inventory { get; set; } = new PlayerInventory();
        public override IList<ISkill> Skills { get; set; } = new List<ISkill>()
        {
            new DoubleTap()
        };
    }
}
