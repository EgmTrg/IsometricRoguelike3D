using IsometricRoguelike.Health;
using IsometricRoguelike.Interact;
using UnityEngine.AI;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    [RequireComponent(typeof(NavMeshAgent), typeof(Rigidbody))]
    public abstract class Friendly : Interactable, IAlive
    {
        #region Props
        #region FromInterface
        public HealthSettings HealthSettings { get; set; }
        public Transform TargetTransform { get; set; }
        #endregion
        [Header("For NavMeshAgent")]
        [SerializeField] protected NavMeshAgent agent;

        [Header("Health")]
        [SerializeField] protected HealthSettings healthSettings;
        #endregion

        protected override void Awake()
        {
            base.Awake();
            HealthSettings = HealthManager.InstantiateHealthSetting(healthSettings);
        }

        void Start()
        {
            if (HealthSettings == null)
                Debug.LogError($"{gameObject.name} has no HealthSettings");

            TargetTransform = GameObject.FindWithTag("Player").transform;
        }
    }
}