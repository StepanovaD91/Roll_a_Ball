using UnityEngine;
using Random = UnityEngine.Random;
using static UnityEngine.Debug;

namespace Maze
{
    public class BadBonuses : InteractiveObject, IFlicker, IRotation
    {
        [SerializeField] public MeshRenderer _meshRenderer;
        private float _lengthFly;
        private float _speedRotation;


        private void Awake()
        {
            _speedRotation = Random.Range(2f, 50f);

        }

        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }
        public void Flick()
        {
            var alpha = Mathf.PingPong(Time.time, 1.0f);
            foreach (var mat in _meshRenderer.materials)
            {
                mat.color = new Color(mat.color.r, mat.color.g, mat.color.b, alpha);
            }
        }

        protected override void Interaction(GameObject interacted)
        {
            interacted.GetComponent<Player>().SpeedBadBonus();

            if (interacted.gameObject.tag == "Player")
            {
                Log("Замедление передвижения");
            }
        }
    }
}