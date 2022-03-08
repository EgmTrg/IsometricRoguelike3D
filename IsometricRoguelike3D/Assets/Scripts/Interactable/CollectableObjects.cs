using System;
using System.Collections.Generic;
using UnityEngine;

namespace IsometricRoguelike.Interactable.Collectable
{
    public class CollectableObjects : InteractableObjects
    {
        protected bool collected = false;

        protected override void OnCollisionEnter(Collision collision)
        {
            // Normalde objeler bize doğru çekilecek. Fakat şimdilik player collider ile item collider çarpıştığında o itemı player alacak.
            Debug.Log("Taken item : " + collision.gameObject.name);
            if (collision.gameObject.CompareTag("Player"))
            {
                OnCollect();
            }
        }

        protected virtual void OnCollect()
        {
            Debug.Log("OnCollect");
        }

        protected virtual void AfterCollect()
        {
            Debug.Log("AfterCollect");
        }
    }
}