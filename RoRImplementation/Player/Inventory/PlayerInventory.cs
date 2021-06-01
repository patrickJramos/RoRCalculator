using RoR;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoRImplementation.Player.Inventory
{
    public class PlayerInventory : IPlayerInventory
    {
        public IDictionary<int, IItemStack> Items { get; private set; } = new Dictionary<int, IItemStack>();
        public IItemStack this[int id] { get => Items[id]; set => Items[id] = value; }

        public void AddSingleItem(IItem item)
        {
            if (!Items.ContainsKey(item.Id))
                Items.Add(item.Id, new ItemStack { Item = item, StackAmout = 1 });
        }

        public void RemoveItem(int itemID)
        {
            if (Items.ContainsKey(itemID))
                Items.Remove(itemID);
        }
    }
}
