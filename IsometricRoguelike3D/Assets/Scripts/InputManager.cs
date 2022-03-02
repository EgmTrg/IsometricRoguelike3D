using System.Collections;
using UnityEngine;

namespace IsometricRoguelike.Input
{
    public class InputManager : MonoBehaviour
    {
        void Update()
        {
            NumericalInputs();
        }

        private void NumericalInputs()
        {
            InputData.Movement.Horizontal = UnityEngine.Input.GetAxis("Horizontal");
            InputData.Movement.Vertical = UnityEngine.Input.GetAxis("Vertical");
        }
    }
}