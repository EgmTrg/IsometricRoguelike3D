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

        private void Reset()
        {
            Debug.LogError($"The {this.name} is a superclass. It can only be used as an inheritance to create Enemy subclasses.");
            DestroyImmediate(GetComponent<Enemy>());
        }
    }
}