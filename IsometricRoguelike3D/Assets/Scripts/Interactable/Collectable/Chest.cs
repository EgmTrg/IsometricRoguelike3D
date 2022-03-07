using UnityEngine;

namespace IsometricRoguelike.Interactable.Collectable
{
    public class Chest : CollectableObjects
    {
        protected override void Awake()
        {
            base.Awake();
        }

        protected override void OnCollect()
        {
            base.OnCollect();
            // animation plays.
        }

        protected override void AfterCollect()
        {
            base.AfterCollect();
            // Adds or spawn collected item then destroy it.
            //Destroy(gameObject);
        }
    }
}