using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public interface IDamageable
    {
        public GameObject thisGameObject { get; set; }
    }
}