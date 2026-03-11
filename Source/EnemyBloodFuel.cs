using UnityEngine;
using Nyxpiri.ULTRAKILL.NyxLib;
using System;

namespace Nyxpiri.ULTRAKILL.BloodFueledEnemies
{
    public static class EnemyBloodFuelEnemyComponentsExtension
    {
        public static EnemyBloodFuel GetBloodFuel(this EnemyComponents enemy)
        {
            return enemy.GetMonoByIndex<EnemyBloodFuel>(EnemyBloodFuel.MonoRegistrarIdx);
        }
    }

    public class EnemyBloodFuel : EnemyModifier
    {
        public EnemyComponents Enemy { get; private set; } = null;
        public static int MonoRegistrarIdx { get; private set; }

        internal static void Initialize()
        {
            MonoRegistrarIdx = EnemyComponents.MonoRegistrar.Register<EnemyBloodFuel>();
        }

        protected void Start()
        {
            PlayerEvents.PreHurt += PlayerPreHurt;
            Enemy = GetComponent<EnemyComponents>();
        }

        protected void OnDestroy()
        {
            PlayerEvents.PreHurt -= PlayerPreHurt;
        }

        private void PlayerPreHurt(EventMethodCanceler canceler, PlayerComponents player, int damage, int processedDamage, bool invincible, float scoreLossMultiplier, bool explosion, bool instablack, float hardDamageMultiplier, bool ignoreInvincibility)
        {
            if (NyxLib.Cheats.IsCheatEnabled(Cheats.BloodFueledEnemies))
            {
                var playerPos = player.NewMovement.rb.transform.position;
                var pos = transform.position;

                var dist = Vector3.Distance(playerPos, pos);

                float maxDist = damage / Options.BloodFuelEnemiesDistDivisor.Value;

                float normalizedDist = 1.0f - Mathf.Min(1.0f, dist / maxDist);
                
                float heal = (damage * normalizedDist);
                heal *= Options.BloodFuelEnemiesHealScalar.Value;

                Enemy.Health = Mathf.Min(Enemy.InitialHealth, Enemy.Health + heal);
            }
        }
    }
}