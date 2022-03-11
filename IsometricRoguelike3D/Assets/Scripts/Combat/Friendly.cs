using IsometricRoguelike.Health;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public class Friendly : MonoBehaviour, IAlive
    {
        public GameObject thisGameObject { get; set; }
        public HealthSettings HealthSettings { get; set; }
        public void InstantiateHealth(HealthSettings healthSettings)
        {
            HealthSettings = Instantiate<HealthSettings>(healthSettings);
        }

        private void Reset()
        {
            Debug.LogError($"The {this.name} is a superclass. It can only be used as an inheritance to create Enemy subclasses.");
            DestroyImmediate(GetComponent<Enemy>());
        }
    }
}