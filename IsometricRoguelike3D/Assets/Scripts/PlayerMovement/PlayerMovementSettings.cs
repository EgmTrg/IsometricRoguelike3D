using UnityEngine;

namespace IsometricRoguelike.Player.Movement
{
    [CreateAssetMenu(fileName = "PlayerMovementSettings", menuName = "IsometricRoguelike/Player/MovementSettings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        [SerializeField] private float playerSpeed;
        [SerializeField] private float horizontalSpeed;
        [SerializeField] private float verticalSpeed;

        public float PlayerSpeed
        {
            get { return playerSpeed; }
            set { playerSpeed = value; }
        }

        public float HorizontalSpeed
        {
            get { return horizontalSpeed; }
            set { horizontalSpeed = value; }
        }
        
        public float VerticalSpeed
        {
            get { return verticalSpeed; }
            set { verticalSpeed = value; }
        }
    }
}
