using IsometricRoguelike.Combat;
using IsometricRoguelike.Health;
using UnityEngine;

namespace Assets.Scripts.Combat.Enemy
{
    public class NPC_One : Friendly
    {
        [SerializeField] private HealthSettings healthSettings;

        // Use this for initialization
        void Awake()
        {
            base.InstantiateHealth(healthSettings);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}