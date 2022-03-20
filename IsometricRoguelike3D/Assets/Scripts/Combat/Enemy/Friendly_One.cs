using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public class Friendly_One : Friendly
    {
        protected override void Awake()
        {
            base.Awake();
            base.agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }

        protected override void Interact()  {   }

        protected override void AfterInteract() { }

        protected override void EndOfInteract() { }
    }
}