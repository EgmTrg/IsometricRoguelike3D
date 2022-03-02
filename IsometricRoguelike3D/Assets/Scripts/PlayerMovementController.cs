using IsometricRoguelike.Input;
using UnityEngine;

namespace IsometricRoguelike.Player.Movement
{

    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private PlayerMovementSettings _settings;

        // Start is called before the first frame update

        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            _rigidbody.velocity = new Vector3(InputData.Movement.Horizontal, 0, InputData.Movement.Vertical) * _settings.PlayerSpeed * 100 * Time.deltaTime;
        }
    }
}
