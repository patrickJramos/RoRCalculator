using System;
using System.Collections.Generic;
using System.Text;

namespace RoR
{
    public interface IItem
    {
        int Id { get; }
        string Name { get; set; }
        void OnGetItem(IPlayer player);
        void OnAddStack(IPlayer player, int amount);
        void OnLoseItem(IPlayer player);
        void OnLoseStack(IPlayer player, int amount);
        void RecalculateStats(int stackSize);
    }
}
