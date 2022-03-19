using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public class CombatBase : MonoBehaviour
    {
        [SerializeField] private Transform combatOffset;
        [SerializeField] [Range(.5f, 2f)] private float combatRadius = .5f;
        [SerializeField] [Range(1f, 7.5f)] private float rayDistance = 1f; // If that value greater than 7.5f, the ray will be out of camera offset.

        private Collider[] hitsCollider;

        #region TemporaryMethods
        private void TemperoryRangedCombat()
        {
            RaycastHit hitInfo;
            bool hit = Physics.Raycast(combatOffset.transform.position, combatOffset.forward, out hitInfo, rayDistance);
            Debug.DrawRay(combatOffset.transform.position, combatOffset.forward, Color.red);

            if (hit)
            {
                //Debug.Log(hitInfo.transform.name);
            }
        }

        private void TemporaryMeleeCombat()
        {
            hitsCollider = Physics.OverlapSphere(combatOffset.position, combatRadius);
            foreach (var collider in hitsCollider)
            {
                //Debug.Log($"hits to {collider.gameObject.name}");
            }
        }
        #endregion

        protected virtual void RangedCombat()
        {
            // Burada kullanilan silah belirlenecek ve bu silahin ateş edilmesi gerçekleşecek.
            // There will be determining of used gun and shooting operations.
            TemperoryRangedCombat();
        }

        protected virtual void MeleeCombat()
        {
            // Burada kullanilan silah belirlenecek ve bu silahin ateş edilmesi gerçekleşecek.
            // There will be determining of used weapon and attacking operations.
            TemporaryMeleeCombat();
        }

        private void OnDrawGizmosSelected()
        {
            if (combatOffset != null)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(combatOffset.transform.position, combatRadius);
            }
        }
    }
}
