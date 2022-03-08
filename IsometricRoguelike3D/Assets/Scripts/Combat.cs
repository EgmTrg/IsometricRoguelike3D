using UnityEngine;
using Utility;

namespace IsometricRoguelike.Combat
{
    public class Combat : MonoBehaviour
    {
        [SerializeField] private float radius = 1;
        [SerializeField] private LayerMask detectLayer;

        protected virtual void Update()
        {
            Attack();
        }

        protected virtual void Attack()
        {
            Collider[] hits = Physics.OverlapSphere(transform.position, radius, detectLayer);
            if (hits != null)
            {
                foreach (Collider hit in hits)
                {
                    //Debug.Log(hit.gameObject.name);
                }
            }
        }

        protected virtual void OnDrawGizmosSelected()
        {
            Gizmos.DrawSphere(transform.position, radius);
        }
    }
}