using System.Collections.Generic;
using UnityEngine;

namespace IsometricRoguelike.Interactable.Collectable
{
    public class CollectableObjects : InteractableObjects
    {
        protected bool collected = false;
        protected List<int> dropItemIDList; // ID or Prefab. If i use prefab, int must be change to gameobject i guess. I am not sure :D
        [SerializeField] private MeshRenderer _meshRenderer;

        protected virtual void Awake()
        {
            _meshRenderer= GetComponent<MeshRenderer>();
            _meshRenderer.material.color= Color.yellow;
        }

        protected override void OnCollisionEnter(Collision collision)
        {
            base.OnCollisionEnter(collision);

            Debug.Log("Trigger Enter to : " + collision.gameObject.name);
            if (collision.gameObject.name == "Player")
            {
                OnCollect();
            }
        }

        protected override void OnCollisionExit(Collision collision)
        {
            base.OnCollisionExit(collision);
            Debug.Log("Trigger Exit from : " + collision.gameObject.name);
        }
        
        protected virtual void OnCollect()
        {
            if (!collected)
            {
                collected = true;
                Debug.Log(gameObject.name + " Collected!");
                AfterCollect(); // Temp method for now. Maybe i will use who knows, for anims etc.
            }
        }

        protected virtual void AfterCollect()
        {
            _meshRenderer.material.color = Color.green;
        }
    }
}