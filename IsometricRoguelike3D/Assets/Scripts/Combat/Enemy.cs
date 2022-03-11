using IsometricRoguelike.Health;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    [HideInInspector]
    public class Enemy : MonoBehaviour, IAlive
    {
        public GameObject thisGameObject { get; set; }
        public HealthSettings HealthSettings { get; set; }
        public void InstantiateHealth(HealthSettings healthSettings)
        {
            HealthSettings = Instantiate<HealthSettings>(healthSettings);
        }

        void Start()
        {
            if (HealthSettings == null)
            {
                Debug.LogError($"{gameObject.name} has no HealthSettings");
            }
        }

        void Update()
        {

        }
    }
}