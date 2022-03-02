using System.Collections;
using UnityEngine;

namespace IsometricRoguelike.Input
{
    public static class InputData
    {
        public static class Movement
        {
            [Header("Numericals")]
            [SerializeField] private static float _horizontal;
            [SerializeField] private static float _vertical;

            public static float Vertical
            {
                get { return _vertical; }
                set { _vertical = value; }
            }

            public static float Horizontal
            {
                get { return _horizontal; }
                set { _horizontal = value; }
            }
        }
    }
}