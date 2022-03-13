using UnityEngine;

namespace IsometricRoguelike.Input
{
    public class InputManager : MonoBehaviour
    {
        void Update()
        {
            NumericalInputs();
            IsometricInputs();
            KeyCodeControl();
        }

        private void NumericalInputs()
        {
            InputData.Movement.Horizontal_GetAxisRaw = UnityEngine.Input.GetAxisRaw("Horizontal");
            InputData.Movement.Vertical_GetAxisRaw = UnityEngine.Input.GetAxisRaw("Vertical");
        }

        private void KeyCodeControl()
        {
            InputData.Combat.CombatKey = UnityEngine.Input.GetButtonDown("Fire1");
        }

        private void IsometricInputs()
        {
            InputData.Movement.MovementVelocity =
                new Vector3(UnityEngine.Input.GetAxisRaw("Horizontal"), 0f, UnityEngine.Input.GetAxisRaw("Vertical"));
        }
    }
}