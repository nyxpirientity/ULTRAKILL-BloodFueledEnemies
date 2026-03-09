using UnityEngine;
using BepInEx;

namespace Nyxpiri.ULTRAKILL.BloodFueledEnemies
{
    [BepInPlugin("com.nyxpiri.bepinex.plugins.ultrakill.blood-fueled-enemies", "Blood Fueled Enemies", "0.0.0.1")]
    [BepInProcess("ULTRAKILL.exe")]
    public class BloodFueledEnemies: BaseUnityPlugin
    {
        protected void Awake()
        {
            Log.Initialize(Logger);
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
