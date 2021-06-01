using RoR;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoRImplementation.Player.Inventory
{
    class ItemStack : IItemStack
    {
        public IItem Item { get; set; }
        public int StackAmout { get; set; }
    }
}
