using IsometricRoguelike.Input;
using UnityEngine;
using Utility.Isometric;

namespace IsometricRoguelike.Player.Movement
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerMovementSettings _settings;
        [SerializeField] private UnityEngine.Camera _currentCamera;
        [SerializeField] private Rigidbody _rigidbody;

        void FixedUpdate()
        {
            IsometricMovement();
            IsometricRotation();
        }

        private void IsometricMovement()
        {
            _rigidbody.MovePosition(transform.position + InputData.Movement.MovementVelocity.ToIsometric() * _settings.PlayerSpeed);
        }

        /// <summary>
        /// Cast a ray from the camera to the mouse cursor. And ray touchs anything as an object then rotate.
        /// </summary>
        private void IsometricRotation()
        {
            Ray cameraRay = _currentCamera.ScreenPointToRay(UnityEngine.Input.mousePosition);
            if (Physics.Raycast(cameraRay, out RaycastHit hit))
                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }
}
