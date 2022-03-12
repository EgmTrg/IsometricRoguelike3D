using IsometricRoguelike.Combat;
using IsometricRoguelike.Health;
using UnityEngine;

namespace Assets.Scripts.Combat.Enemy
{
    public class Friendly_One : Friendly
    {
        [SerializeField] private HealthSettings healthSettings;

        protected override void Awake()
        {
            base.Awake();
            base.InstantiateHealth(healthSettings);
        }
    }
}