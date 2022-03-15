using IsometricRoguelike.Health;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public class Enemy_One : Enemy
    {
        [SerializeField] private HealthSettings healthSettings;

        protected override void Awake()
        {
            base.Awake();
            base.InstantiateHealth(healthSettings);
            base.agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }
    }
}
