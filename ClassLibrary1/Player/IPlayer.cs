using RoR.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoR
{
    public interface IPlayer
    {
        IPlayerStats Stats { get; set; }
        IPlayerInventory Inventory { get; set; }
        IList<ISkill> Skills { get; set; }

        void GiveItem(int id, IItem item);
        void Hit(float baseDamage, bool canCrit);
    }
}
