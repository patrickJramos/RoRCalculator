using RoR;
using RoRImplementation.Player.Inventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoRImplementation.Items
{
    public class AtGMissile : IItem
    {
        public int Id { get; } = 1;

        public string Name { get; set; } = "Atg Missle Launcher";

        public float Multiplier = 3;

        public float ProcChance = 0.3f;


        public void OnGetItem(IPlayer player)
        {
            player.Stats.OnHit.Add(AtgProc);

            player.Inventory.AddSingleItem(new AtGMissile());
            
            var itemStack = player.Inventory[Id];
            itemStack.Item.RecalculateStats(itemStack.StackAmout);
        }

        public void OnAddStack(IPlayer player, int amount)
        {
            var itemStack = player.Inventory.Items[Id];
            itemStack.StackAmout += amount;
            itemStack.Item.RecalculateStats(itemStack.StackAmout);
        }

        public void OnLoseItem(IPlayer player)
        {
            player.Stats.OnHit.Remove(AtgProc);
            player.Inventory.RemoveItem(Id);
        }

        public void OnLoseStack(IPlayer player, int amount)
        {
            OnAddStack(player, -amount);
        }

        void AtgProc(IPlayer player, float hitDamage, Random rng)
        {
            var luck = player.Stats.Luck;
            var procCoef = player.Stats.ProcCoeficcient;
            float chance;
            
            if(luck >= 0)
                chance = MathF.Pow(1 - ProcChance, 1 + luck);
            else
                chance = 1 - MathF.Pow(ProcChance, 1 - luck);
            var happens = rng.NextDouble() >= chance;

            if (!happens)
            {
                Console.WriteLine($"Atg failed to proc with {1 - chance} chance");
                return;
            }

            var item = (AtGMissile)player.Inventory.Items[Id].Item;
            var damage = hitDamage * item.Multiplier * procCoef;

            player.Hit(damage, canCrit: true);
        }

        public void RecalculateStats(int stackSize)
        {
            Multiplier = 3 * stackSize;
        }
    }
}
