using System;
using UnityEngine;
using Random = UnityEngine.Random;
using static UnityEngine.Debug;

namespace Maze
{
    public class DeadBonuses : InteractiveObject, IFly, IRotation
    {
        [SerializeField] public MeshRenderer _meshRenderer;
        private float _lengthFly;
        private float _speedRotation;


        private void Awake()
        {
            _lengthFly = 1.2f;
            _speedRotation = Random.Range(15f, 70f);

        }
        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, _lengthFly), transform.position.z);
        }
        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }

        protected override void Interaction(GameObject interacted)
        {
            try
            {
                if (interacted.gameObject.CompareTag("Player"))
                {
                    CameraShake.ShakeDelegate.Invoke(0.25f);
                    Destroy(gameObject);
                    Application.LoadLevel(Application.loadedLevel);
                    Log("Проигрыш");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}