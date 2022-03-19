using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public class Friendly_One : Friendly
    {
        protected override void Awake()
        {
            base.Awake();
            base.InstantiateHealth();
        }
    }
}