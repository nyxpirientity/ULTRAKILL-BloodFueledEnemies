using UnityEngine;
using BepInEx;
using System;

namespace Nyxpiri.ULTRAKILL.BloodFueledEnemies
{
    public static class Cheats
    {
        public const string BloodFueledEnemies = "nyxpiri.blood-fueled-enemies";
    }
    [BepInPlugin("com.nyxpiri.bepinex.plugins.ultrakill.blood-fueled-enemies", "Blood Fueled Enemies", "0.0.0.1")]
    [BepInProcess("ULTRAKILL.exe")]
    public class BloodFueledEnemies: BaseUnityPlugin
    {
        protected void Awake()
        {
            Log.Initialize(Logger);
            EnemyBloodFuel.Initialize();
            NyxLib.Cheats.ReadyForCheatRegistration += RegisterCheats;
        }

        private void RegisterCheats(CheatsManager cheatsManager)
        {
            cheatsManager.RegisterCheat(new ToggleCheat(
                "Blood Fueled Enemies", 
                Cheats.BloodFueledEnemies,
                onDisable: (cheat) =>
                {
                    
                },
                onEnable: (cheat, manager) =>
                {
                    
                }
            ), "FAIRNESS AND EQUALITY");
        }

        protected void Start()
        {
        }

        protected void Update()
        {

        }

        protected void LateUpdate()
        {

        }
    }
}
