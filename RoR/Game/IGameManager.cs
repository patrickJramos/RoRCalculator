using System;
using System.Collections.Generic;
using System.Text;

namespace RoR
{
    public interface IGameManager
    {
        IItemManager ItemManager { get; }
        IPlayer Player { get; set; }
        //Gives an item with the given ID from the ItemManager to the Player
        void GiveItemToPlayer(int itemID);
    }

}
