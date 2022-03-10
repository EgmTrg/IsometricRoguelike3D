using IsometricRoguelike.Interactable;
using IsometricRoguelike.Health;
using UnityEngine;

namespace IsometricRoguelike.Entities
{
    public class Entity : InteractableObjects
    {
        [Space(10)]
        [SerializeField] protected HealthSettings healthsettings;
    }
}