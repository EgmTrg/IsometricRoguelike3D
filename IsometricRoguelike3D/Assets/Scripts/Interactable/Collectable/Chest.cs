﻿using IsometricRoguelike.Entities;
using System.Collections.Generic;
using UnityEngine;

namespace IsometricRoguelike.Interactable.Collectable
{
    public class Chest : Entity
    {
        // Chest bir entity, yani bir canı olacak ve hasar verildiğinde canı azalıp kırılacak. Kırılınca item düşürecek. 
        // Düşen itemlar CollectableObject'ten inheritance alacak.

        protected List<int> dropItemIDList; // ID or Prefab. If i use prefab, int must be change to gameobject i guess. I am not sure :D

        protected override void Awake()
        {
            base.Awake();
        }

        protected override void OnCollisionEnter(Collision collision)
        {
            base.OnCollisionEnter(collision);
        }


        protected override void OnCollisionExit(Collision collision)
        {
            base.OnCollisionExit(collision);
        }
    }
}