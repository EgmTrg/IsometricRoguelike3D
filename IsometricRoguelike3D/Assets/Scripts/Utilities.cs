using System;
using UnityEngine;

namespace Utility
{
    namespace Isometric
    {
        public static class Isometrics
        {
            private static Matrix4x4 _isoMatrix = Matrix4x4.Rotate(Quaternion.Euler(0, 45, 0));
            public static Vector3 ToIsometric(this Vector3 input) => _isoMatrix.MultiplyPoint3x4(input);
        }
    }

    public static class Utilities
    {

        /// <summary>
        /// Does the given GameObject have this Component?
        /// </summary>
        /// <typeparam name="T">Any Component</typeparam>
        /// <param name="gameObject"></param>
        /// <returns></returns>
        public static bool HasComponent<T>(this GameObject gameObject) where T : Component
        {
            return gameObject.GetComponent<T>() != null;
        }

        /// <summary>
        /// Gives the mouseposition according to the given camera.
        /// </summary>
        /// <param name="camera"></param>
        /// <returns></returns>
        public static Vector3 GetMousePositionOnScreen(UnityEngine.Camera camera)
        {
            return camera.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
        }

        /// <summary>
        /// Gives the player position.
        /// </summary>
        /// <param name="camZoffset">True: player.z = camera.z; False: player.z = 0;</param>
        /// <returns>Vector3(player.x,player.y,camZoffset)</returns>
        public static Vector3 GetPlayerPosition(bool camZoffset)
        {
            Vector3 pPos = GameObject.FindWithTag("Player").transform.position;
            pPos.z = camZoffset ? UnityEngine.Camera.main.transform.position.z : 0f;
            return pPos;
        }

        /// <summary>
        /// If aim gameobject is a child gameobject, parameter.transform must be parent transform.
        /// In brief, parameter.transform has to be Player transform not aimGameObject's transform.
        /// </summary>
        /// <param name="_transform"></param>
        /// <param name="aimTransform"></param>
        /// <param name="angle"></param>
        public static Vector3 LookAtMousePosition(Transform _transform, UnityEngine.Camera _camera)
        {
            Vector3 mousePos = GetMousePositionOnScreen(_camera);
            Vector3 aimDirection = (mousePos - _transform.position).normalized;
            float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

            return new Vector3(0, 0, angle);
        }

        public class TextOperations : MonoBehaviour
        {
            public static void CreatePopupText(GameObject popupPrefab, Transform gameObjectTransform)
            {
                PopupText(popupPrefab, gameObjectTransform, Color.white);
            }

            public static void CreatePopupText(GameObject popupPrefab, Transform gameObjectTransform, Vector3 popupPos, Color? color = null)
            {
                if (color == null) color = Color.white;
                PopupText(popupPrefab, gameObjectTransform, (Color)color);
            }

            public static void CreatePopupText(GameObject popupPrefab, Transform popupSpawnTransform, Color color, float popupTime = 1)
            {
                PopupText(popupPrefab, popupSpawnTransform, color, popupTime);
            }

            private static void PopupText(GameObject popupPrefab, Transform popupSpawnTransform, Color color, float popupTime = 1)
            {
                //popupPrefab.GetComponent<Renderer>().material.color = color;
                Debug.Log("instantiate area");
                Instantiate(popupPrefab, popupSpawnTransform.position, popupSpawnTransform.transform.rotation);
                //Destroy(popupPrefab, popupTime);
            }
        }

    }
}
