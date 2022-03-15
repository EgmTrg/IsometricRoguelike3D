using System.Collections;
using UnityEngine;

namespace IsometricRoguelike.Input
{
    public static class InputData
    {
        public static class Movement
        {
            [Header("Numericals")]
            [SerializeField] private static Vector3 _isometricMovementDirection;
            [SerializeField] private static float _horizontal;
            [SerializeField] private static float _vertical;

            public static Vector3 MovementVelocity
            {
                get { return _isometricMovementDirection; }
                set { _isometricMovementDirection = value; }
            }

            public static float Vertical_GetAxisRaw
            {
                get { return _vertical; }
                set { _vertical = value; }
            }

            public static float Horizontal_GetAxisRaw
            {
                get { return _horizontal; }
                set { _horizontal = value; }
            }
        }

        public static class Combat
        {
            [Header("Keys")]
            [SerializeField] private static bool _meleeCombatKey;
            [SerializeField] private static bool _rangedCombatKey;

            public static bool RangedCombatKey
            {
                get { return _rangedCombatKey; }
                set { _rangedCombatKey = value; }
            }

            public static bool MeleeCombatKey
            {
                get { return _meleeCombatKey; }
                set { _meleeCombatKey = value; }
            }
        }
    }
}