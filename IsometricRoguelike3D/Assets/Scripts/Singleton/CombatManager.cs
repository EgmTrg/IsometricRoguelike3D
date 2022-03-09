using UnityEngine;

namespace IsometricRoguelike.Singletons
{
    public class CombatManager : MonoSingleton<CombatManager>
    {
        private void Awake()
        {
            Debug.Log("CombatManager Instantiated.");
        }

        /*private HealthSystem healthSystem;

        public CombatManager(HealthSystem healthSystem)
        {
            this.healthSystem = healthSystem;
        }*/

        public static void TakeDamage(int damage)
        {

        }

        public static void TakeHeal(int heal)
        {

        }
    }
}