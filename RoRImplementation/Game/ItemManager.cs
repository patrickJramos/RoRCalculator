using RoR;
using RoRImplementation.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoRImplementation.Game
{
    public class ItemManager : IItemManager
    {
        public ItemManager()
        {
            FillItems();
        }

        public IReadOnlyDictionary<int, IItem> ItemList { get; private set; }

        public void FillItems()
        {
            if (ItemList != null)
                return;
            List<IItem> items = new List<IItem>()
            {
                new AtGMissile(),
            };
            ItemList = items.ToDictionary(i => i.Id);
        }
    }
}
