using System.Collections;
using UnityEngine;

namespace IsometricRoguelike.Health
{
    [CreateAssetMenu(fileName = "HealthSettings", menuName = "IsometricRoguelike/Combat/HealthSettings")]
    public class HealthSettings : ScriptableObject
    {
        [SerializeField] private float _maxHealth;
        [SerializeField] private float _currentHealth;
        [SerializeField] private bool _isAlive;
        public int MinimumHealth { get { return 0; } }

        public bool IsAlive
        {
            get { return _isAlive; }
            set { _isAlive = value; }
        }

        public float Health_Current
        {
            get { return _currentHealth; }
            set { _currentHealth = value; }
        }

        public float Health_Max
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }

    }
}