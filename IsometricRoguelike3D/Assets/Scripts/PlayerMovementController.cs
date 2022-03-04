using IsometricRoguelike.Input;
using UnityEngine;

namespace IsometricRoguelike.Player.Movement
{

    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private PlayerMovementSettings _settings;

        [SerializeField] private float speedMultiplier = 1f;

        void FixedUpdate()
        {
            IsometricMovement();
            IsometricRotation();
        }

        private void IsometricMovement()
        {
            _rigidbody.MovePosition(transform.position + transform.forward * _settings.PlayerSpeed * speedMultiplier * Time.deltaTime);
        }

        private void IsometricRotation()
        {
            var relative = (transform.position + InputData.Movement.MovementDirection) - transform.position;
            var rot = Quaternion.LookRotation(relative, Vector3.up);
            transform.rotation = rot;
        }
    }
}
