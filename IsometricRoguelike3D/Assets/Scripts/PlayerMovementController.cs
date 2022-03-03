using IsometricRoguelike.Input;
using UnityEngine;

namespace IsometricRoguelike.Player.Movement
{

    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private PlayerMovementSettings _settings;
        [SerializeField] private Transform _cameraTransform;

        private float smoothVelocity;
        private float smoothTime = 0.1f;

        void FixedUpdate()
        {
            Movement();
        }

        private void Movement()
        {
            Vector3 direction = new Vector3(InputData.Movement.Horizontal, 0, InputData.Movement.Vertical).normalized;
            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = RotationToDirection(direction);
                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                _characterController.Move(moveDir.normalized * _settings.PlayerSpeed * Time.deltaTime);
            }
        }

        private float RotationToDirection(Vector3 direction)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + _cameraTransform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.rotation.eulerAngles.y, targetAngle, ref smoothVelocity, smoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            return targetAngle;
        }

    }
}
