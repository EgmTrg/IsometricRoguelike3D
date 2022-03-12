using IsometricRoguelike.Interact;
using IsometricRoguelike.Health;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public class Enemy : Interactable, IAlive
    {
        #region FromInterface
        public HealthSettings HealthSettings { get; set; }
        #endregion

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

        protected override void Interact()
        {
            base.Interact();
            // There will be attack operations and health management.
        }
    }
}