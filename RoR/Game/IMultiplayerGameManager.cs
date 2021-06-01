using System;
using System.Collections.Generic;
using System.Text;

namespace RoR
{
    public interface IMultiplayerGameManager
    {
        IItemManager ItemManager { get; set; }
        IList<IPlayer> Player { get; set; }
    }
}
