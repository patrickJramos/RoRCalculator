using System;
using System.Collections.Generic;
using System.Text;

namespace RoR
{
    public interface IPlayerInventory
    {
        IDictionary<int, IItemStack> Items { get; }
        IItemStack this[int id] { get; set; }
        void AddSingleItem(IItem item);
        void RemoveItem(int itemID);
    }
}
