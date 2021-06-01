using System;
using System.Collections.Generic;
using System.Text;

namespace RoR
{
    public interface IItemStack
    {
        IItem Item { get; set; }
        int StackAmout { get; set; }
    }
}
