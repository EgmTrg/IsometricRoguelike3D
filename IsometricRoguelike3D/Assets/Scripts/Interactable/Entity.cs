using IsometricRoguelike.Interactable;
using IsometricRoguelike.Health;
using IsometricRoguelike.Combat;
using UnityEngine;

namespace IsometricRoguelike.Entities
{
    public class Entity : InteractableObjects, ILifeless
    {
        public GameObject thisGameObject { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}