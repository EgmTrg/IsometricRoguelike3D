using System.Collections;
using UnityEngine;
using Utility;

namespace IsometricRoguelike.Singletons
{
    public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {        
        private static readonly GameObject systemGameObject = GameObject.FindGameObjectWithTag("System");
        private static volatile T instance = null;
        public static T Instance
        {
            get
            {
                if (!systemGameObject.HasComponent<T>())
                {
                    systemGameObject.AddComponent<T>();
                }

                if (instance == null)
                {
                    instance = GameObject.FindObjectOfType(typeof(T)) as T;
                }

                return instance;
            }
        }
    }
}