using RoR;
using RoR.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoRImplementation.Player
{
    public abstract class Player : IPlayer
    {
        abstract public IPlayerStats Stats { get; set; }
        abstract public IPlayerInventory Inventory { get; set; }
        abstract public IList<ISkill> Skills { get; set; }
        public Random Rng { get; set; } = new Random();

        public void GiveItem(int id, IItem item)
        {
            if (Inventory.Items.ContainsKey(item.Id))
            {
                item.OnAddStack(this, 1);
            }
            else
            {
                item.OnGetItem(this);
            }
        }

        public void Hit(float baseDamage, bool canCrit)
        {
            Console.WriteLine(Environment.StackTrace);
            Stats.TotalDamageDealt += baseDamage;
            foreach (var onHit in Stats.OnHit)
            {
                onHit.Invoke(this, baseDamage, Rng);
            }
        }
    }
}
