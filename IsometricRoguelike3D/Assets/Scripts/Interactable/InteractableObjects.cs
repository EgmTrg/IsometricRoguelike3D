﻿using System;
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
                Interact(collision.gameObject, 1);
            }
        }

        private void Interact(GameObject gameobject_willDestroy, float destroyTime)
        {
            Destroy(gameobject_willDestroy, destroyTime);
        }
    }
}