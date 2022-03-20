using IsometricRoguelike.Combat;
using IsometricRoguelike.Interact;
using UnityEngine;

namespace Assets.Scripts
{
    public class Chest : Interactable, ILifeless
    {
        protected override void Interact() { }

        protected override void AfterInteract() { }

        protected override void EndOfInteract() { }
    }
}