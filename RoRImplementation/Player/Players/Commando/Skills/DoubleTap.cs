using RoR;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoRImplementation.Player.Players.Commando.Skills
{
    public class DoubleTap : ISkill
    {
        public void Activate(IPlayer player)
        {
            player.Hit(player.Stats.BaseDamage * 0.8F, true);
            player.Hit(player.Stats.BaseDamage * 0.8F, true);
        }
    }
}
