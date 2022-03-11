using IsometricRoguelike.Health;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public class Enemy_One : Enemy
    {
        [SerializeField] private HealthSettings healthSettings;

        void Awake()
        {
            base.InstantiateHealth(healthSettings);
        }


        void Update()
        {

        }
    }
}
