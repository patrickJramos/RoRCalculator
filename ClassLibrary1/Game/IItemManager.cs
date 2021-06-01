using System;
using System.Collections.Generic;
using System.Text;

namespace RoR
{
    public interface IItemManager
    {
        IReadOnlyDictionary<int, IItem> ItemList { get; }
    }

}
