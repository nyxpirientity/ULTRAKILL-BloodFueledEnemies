using System.Collections.Generic;
using BepInEx.Configuration;

namespace Nyxpiri.ULTRAKILL.BloodFueledEnemies
{
    public static class Options
    {
        public static ConfigEntry<float> BloodFuelEnemiesHealScalar = null;
        public static ConfigEntry<float> BloodFuelEnemiesDistDivisor = null;

        public static void Initialize()
        {
            BloodFuelEnemiesHealScalar = Config.Bind($"Balance", "BloodFuelEnemiesHealScalar", 0.4f);
            BloodFuelEnemiesDistDivisor = Config.Bind($"Balance", "BloodFuelEnemiesDistDivisor", 8.0f);
        }
        
        internal static ConfigFile Config = null;
    }
}
