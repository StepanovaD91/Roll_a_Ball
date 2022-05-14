using UnityEngine;

namespace Maze
{
    public abstract class InteractiveObject : MonoBehaviour
    {
        public bool IsInteractable { get; protected set; } = true;
        [SerializeField] protected bool DestroyImmediately;
        private Vector3 _position;
        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction(other.gameObject);
            if (DestroyImmediately)
            {
                Destroy(gameObject);
            }

        }

        public void SetBonusPosition(Vector3 position)
        {
            _position = position;
            transform.position = new Vector3(_position.x, _position.y, _position.z);
        }

        public Vector3 Position()
        {
            return _position;
        }
        protected abstract void Interaction(GameObject interacted);

    }
}
