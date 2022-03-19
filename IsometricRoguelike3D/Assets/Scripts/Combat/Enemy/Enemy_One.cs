using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public class Enemy_One : Enemy
    {
        protected override void Awake()
        {
            base.Awake();
            base.agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }
    }
}
