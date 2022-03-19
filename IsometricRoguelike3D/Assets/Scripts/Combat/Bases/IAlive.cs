using IsometricRoguelike.Health;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public interface IAlive : IDamageable
    {
        public HealthSettings HealthSettings { get; set; }
    }
}