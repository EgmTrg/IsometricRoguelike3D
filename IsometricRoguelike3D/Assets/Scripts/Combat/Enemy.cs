using IsometricRoguelike.Health;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public class Enemy : MonoBehaviour, IAlive
    {
        public GameObject thisGameObject { get; set; }
        public HealthSettings HealthSettings { get; set; }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}