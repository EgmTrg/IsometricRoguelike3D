using IsometricRoguelike.Singletons;
using UnityEngine;

namespace IsometricRoguelike.Health
{
    public class HealthManager : MonoSingleton<HealthManager>
    {
        private HealthSettings entityHealthSettings = null;

        public HealthManager(HealthSettings settings)
        {
            if (entityHealthSettings != settings || entityHealthSettings == null)
                entityHealthSettings = settings;
        }

        public static HealthSettings InstantiateHealthSetting(HealthSettings healthSettings) => Instantiate<HealthSettings>(healthSettings);

        public void TakeDamage(int damage)
        {
            var health = Mathf.Clamp(entityHealthSettings.Health_Current - damage, entityHealthSettings.MinimumHealth, entityHealthSettings.Health_Max);
            CheckAlive(health);
        }

        private void CheckAlive(float health)
        {
            if (health == entityHealthSettings.MinimumHealth)
            {
                entityHealthSettings.IsAlive = false;
            }
            else
            {
                entityHealthSettings.Health_Current = health;
            }
        }
    }
}