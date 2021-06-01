using RoR.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoRImplementation.Game
{
    class RNG : IRNG
    {
        public Random Rng { get; set; } = new Random();
        public float NextFloat()
        {
            return (float)Rng.NextDouble();
        }
    }
}
