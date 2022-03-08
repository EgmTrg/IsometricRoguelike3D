using UnityEngine;

namespace IsometricRoguelike.Interactable
{
    public class InteractableObjects : MonoBehaviour
    {
        [SerializeField] private MeshRenderer _meshRenderer;
        [SerializeField] private Color touchedColor;

        protected virtual void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
            touchedColor = Color.green;
        }

        protected virtual void OnCollisionEnter(Collision collision)
        {
            if (_meshRenderer.material.color != touchedColor)
            {
                Debug.Log(gameObject.name + "Touched!");
                // Interact();
                // Aşağıdaki renk değiştirme olayı geçicidir. Dokunduktan sonra destroylanabilir istenirse.
                _meshRenderer.material.color = touchedColor;
            }
            else
            {
                Debug.Log("Already Touched.");
                // Eğer obje destroylanmayacak bir obje ise bu field'a girilecek.
            }
        }

        protected virtual void OnCollisionExit(Collision collision)
        {
            Debug.Log(gameObject.name + "'s Collision Exit from : " + collision.gameObject.name);
        }
    }
}