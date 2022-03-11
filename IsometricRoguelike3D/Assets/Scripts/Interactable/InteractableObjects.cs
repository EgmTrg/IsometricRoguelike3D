using System.Collections.Generic;
using UnityEngine;

namespace IsometricRoguelike.Interactable
{
    public class InteractableObjects : MonoBehaviour
    {
        [SerializeField] private List<string> interactableList;
        private List<GameObject> touchedGameObjects;

        private void Start()
        {
            interactableList.Add("InteractableMask");
        }

        protected virtual void OnCollisionEnter(Collision collision)
        {
            string touchedLayer = LayerMask.LayerToName(collision.gameObject.layer);
            if (interactableList.Contains(touchedLayer))
            {
                Interact(collision.gameObject);
            }
        }

        private void Interact(GameObject interactedGameobject)
        {
            switch (interactedGameobject.name)
            {
                case "Chest":
                    Debug.Log("Touched Chest");
                    Destroy(interactedGameobject, 1);
                    break;
                case "Enemy":
                    Debug.Log("Touched Enemy");
                    break;
                default:
                    Debug.Log("Unknown Object");
                    break;
            }
        }
    }
}