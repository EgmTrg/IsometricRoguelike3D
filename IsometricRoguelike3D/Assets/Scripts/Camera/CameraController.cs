using System.Collections;
using UnityEngine;

namespace IsometricRoguelike.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _playerTransform;

        private void Start()
        {
            _cameraSettings.CameraOffset = transform.position - _playerTransform.position;
        }


        private void Update()
        {
            Vector3 cameraNewPos = _playerTransform.position + _cameraSettings.CameraOffset;
            // 1 is the cameraLerpSpeed.
            transform.position = Vector3.Slerp(transform.position, cameraNewPos, 1);
        }
    }
}