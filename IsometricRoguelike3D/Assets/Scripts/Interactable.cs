using UnityEngine;

namespace IsometricRoguelike.Interact
{
    public abstract class Interactable : MonoBehaviour
    {
        [SerializeField] protected float interactRadius = 1;
        [SerializeField] private Transform playerTransform;
        private bool playerInteractableStatement = true;    // If its true, Player interact with it otherwise can't.
        private bool isPlayer_NearOfInteractable = false;

        #region ForUnityInspector
        protected virtual void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, interactRadius);
        }
        #endregion

        #region Abstract Methods
        protected abstract void Interact();
        protected abstract void AfterInteract();
        protected abstract void EndOfInteract();
        #endregion

        protected virtual void Awake()
        {
            playerTransform = GameObject.FindWithTag("Player").transform;
        }

        private void Update()
        {
            DetectNearInteractables();
        }

        private void DetectNearInteractables()
        {
            float distance = Vector3.Distance(transform.position, playerTransform.position);
            if (distance <= interactRadius)
            {
                if (!isPlayer_NearOfInteractable)
                {
                    Debug.Log($"Player near of {gameObject.name}");
                    isPlayer_NearOfInteractable = true;

                    if (playerInteractableStatement == true)
                    {
                        Interact();
                        AfterInteract();
                        EndOfInteract();
                        playerInteractableStatement = false;
                    }
                }
            }
        }

        protected void RotationToPlayer(Transform target, Transform transform)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 10f);
        }
    }
}