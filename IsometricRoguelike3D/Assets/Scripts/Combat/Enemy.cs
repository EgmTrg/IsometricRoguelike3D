using IsometricRoguelike.Interact;
using IsometricRoguelike.Health;
using UnityEngine.AI;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    [RequireComponent(typeof(NavMeshAgent), typeof(Rigidbody))]
    public class Enemy : Interactable, IAlive
    {
        #region FromInterface
        public HealthSettings HealthSettings { get; set; }
        #endregion
        [Header("For NavMeshAgent")]
        [SerializeField] protected NavMeshAgent agent;
        [SerializeField] private Transform target;

        [Header("Health")]
        [SerializeField] protected HealthSettings healthSettings;

        protected override void Awake()
        {
            base.Awake();
            healthSettings = HealthManager.InstantiateHealthSettings(healthSettings);
        }

        void Start()
        {
            if (HealthSettings == null)
                Debug.LogError($"{gameObject.name} has no HealthSettings");

            target = GameObject.FindWithTag("Player").transform;
        }

        private void Update()
        {
            DetectTarget();
        }

        private void DetectTarget()
        {
            float distance = Vector3.Distance(target.position, transform.position);

            if (distance <= interactRadius)
            {
                agent.SetDestination(target.position);
            }
        }
    }
}