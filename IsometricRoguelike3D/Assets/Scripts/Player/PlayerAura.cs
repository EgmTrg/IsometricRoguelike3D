using UnityEngine;
using Utility;

namespace IsometricRoguelike.Player
{
    public class PlayerAura : MonoBehaviour
    {
        [SerializeField] private float radius = 1;
        [SerializeField] private LayerMask detectLayer;

        private void Update()
        {
            DetectAroundAura();
        }

        private void DetectAroundAura()
        {
            Collider[] detected = Physics.OverlapSphere(transform.position, radius, detectLayer);
            if (detected != null)
            {
                foreach (Collider item in detected)
                {
                    //Debug.Log(item.gameObject.name);
                }
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawSphere(transform.position, radius);
        }
    }
}