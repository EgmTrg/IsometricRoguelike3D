using System.Collections;
using UnityEngine;

namespace IsometricRoguelike.Camera
{
    [CreateAssetMenu(fileName = "CameraSettings", menuName = "IsometricRoguelike/Camera/CameraSettings")]
    public class CameraSettings : ScriptableObject
    {
        [SerializeField] private Vector3 _defaultCameraOffset;
        [SerializeField] private Vector3 _cameraOffset;

        public Vector3 DefaultCameraOffset
        {
            get { return _defaultCameraOffset; }
            private set { _defaultCameraOffset = value; }
        }


        public Vector3 CameraOffset
        {
            get { return _cameraOffset; }
            set { _cameraOffset = value; }
        }
    }
}