using IsometricRoguelike.Health;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public interface IDamageable
    {

    }

    public interface IAlive : IDamageable
    {
        public HealthSettings HealthSettings { get; set; }
    }

    public interface ILifeless : IDamageable
    {

    }
}