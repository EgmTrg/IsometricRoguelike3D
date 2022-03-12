using System.Collections;
using UnityEngine;

namespace IsometricRoguelike.Interact
{
    public class Interactable : MonoBehaviour
    {
        [SerializeField] protected float interactRadius = 1;
        [SerializeField] private Transform playerTransform;
        private bool stateOfInteractable = true;    // If its true, Player interact with it otherwise can't.
        bool playerNearOfInteractable = false;

        #region ForUnityInspector
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, interactRadius);
        }
        /*
                private void Reset()
                {
                    Debug.LogError($"The {this.name} is a superclass. It can only be used as an inheritance to create {this.name} subclasses.");
                    DestroyImmediate(GetComponent<Interactable>());
                }
        */
        #endregion

        protected virtual void Awake()
        {
            playerTransform = GameObject.FindWithTag("Player").transform;
        }

        private void Update()
        {
            float distance = Vector3.Distance(transform.position, playerTransform.position);
            if (distance <= interactRadius)
            {
                if (!playerNearOfInteractable)
                {
                    Debug.Log($"Player near of {gameObject.name}");
                    playerNearOfInteractable = true;

                    if (stateOfInteractable == true)
                    {
                        Interact();
                        stateOfInteractable = false;
                    }
                }
            }
        }

        protected virtual void Interact()
        {
            // There is empty for overwrite..
        }

        protected virtual void AfterInteract()
        {
            // There is empty for overwrite..
        }

        protected virtual void EndOfInteract()
        {
            stateOfInteractable = true;
        }
    }
}