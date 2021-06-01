using RoR;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoRImplementation.Game
{
    public class GameManager : IGameManager
    {
        public GameManager(IItemManager itemManager, IPlayer player)
        {
            ItemManager = itemManager;
            Player = player;
        }

        public IItemManager ItemManager { get; }
        public IPlayer Player { get ; set; }

        public void GiveItemToPlayer(int itemID)
        {
            if (!ItemManager.ItemList.ContainsKey(itemID))
            {
                Console.WriteLine($"Item ID {itemID} not found in {ItemManager.GetType()}");
                return;
            }
            var item = ItemManager.ItemList[itemID];
            Player.GiveItem(itemID, item);
        }
    }
}
