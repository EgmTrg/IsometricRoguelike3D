using IsometricRoguelike.Health;
using IsometricRoguelike.Interact;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public class Friendly : Interactable, IAlive
    {
        #region FromInterface
        public HealthSettings HealthSettings { get; set; }
        #endregion
        [Header("Health")]
        [SerializeField] protected HealthSettings healthSettings;

        public void InstantiateHealth()
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
        }
    }
}