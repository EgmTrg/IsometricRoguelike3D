using IsometricRoguelike.Interact;
using IsometricRoguelike.Health;
using UnityEngine;
using UnityEngine.AI;

namespace IsometricRoguelike.Combat
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class Enemy : Interactable, IAlive
    {
        #region FromInterface
        public HealthSettings HealthSettings { get; set; }
        #endregion

        protected NavMeshAgent agent;
        private Transform target;

        public void InstantiateHealth(HealthSettings healthSettings)
        {
            HealthSettings = Instantiate<HealthSettings>(healthSettings);
        }

        void Start()
        {
            if (HealthSettings == null)
                Debug.LogError($"{gameObject.name} has no HealthSettings");

            target = GameObject.FindWithTag("Player").transform;
        }

        private void Update()
        {
            //DetectTarget();
        }

        /*private void DetectTarget()
        {
            float distance = Vector3.Distance(target.position, transform.position);

            if (distance <= interactRadius)
            {
                agent.SetDestination(target.position);
            }
        }*/
    }
}