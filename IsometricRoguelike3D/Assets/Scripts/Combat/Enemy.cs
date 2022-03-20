using IsometricRoguelike.Interact;
using IsometricRoguelike.Health;
using UnityEngine.AI;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    [RequireComponent(typeof(NavMeshAgent), typeof(Rigidbody))]
    public abstract class Enemy : Interactable, IAlive
    {
        #region Props
        #region FromInterface
        public HealthSettings HealthSettings { get; set; }
        public Transform TargetTransform { get; set; }
        #endregion
        [Header("For NavMeshAgent")]
        [SerializeField] protected NavMeshAgent agent;
        [SerializeField] [Range(1f, 3f)] protected float stoppingDistance;

        [Header("Health")]
        [SerializeField] protected HealthSettings healthSettings;
        #endregion

        #region ForUnityInspector
        protected override void OnDrawGizmosSelected()
        {
            base.OnDrawGizmosSelected();
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, stoppingDistance);
        }
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
            agent.stoppingDistance = stoppingDistance;
        }

        private void Update()
        {
            agent.stoppingDistance = stoppingDistance;

            FollowTheTarget();
        }

        private void FollowTheTarget()
        {
            float Player_EnemyDistance = Vector3.Distance(TargetTransform.position, transform.position);

            if (Player_EnemyDistance <= interactRadius)
            {
                agent.SetDestination(TargetTransform.position);

                if (Player_EnemyDistance <= agent.stoppingDistance)
                {
                    //attack
                    base.RotationToPlayer(TargetTransform, transform);
                }
            }
        }
    }
}