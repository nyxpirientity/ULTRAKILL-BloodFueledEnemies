using System.Collections.Generic;
using BepInEx.Configuration;

namespace Nyxpiri.ULTRAKILL.BloodFueledEnemies
{
    public static class Options
    {
        public static ConfigEntry<float> HealScalar = null;
        public static ConfigEntry<float> DistanceScalar = null;

        public static void Initialize()
        {
            HealScalar = Config.Bind($"Balance", "HealScalar", 0.5f);
            DistanceScalar = Config.Bind($"Balance", "DistanceScalar", 0.25f);
        }
        
        internal static ConfigFile Config = null;
    }
}
