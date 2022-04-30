using System;
using UnityEngine;
using Random = UnityEngine.Random;
using static UnityEngine.Debug;

namespace Maze
{
    public sealed class GoodBonuses : InteractiveObject, IRotation
    {
        private float _speedRotation;
        [SerializeField] private float bonusEffect = 5.0f;
        [SerializeField] private float timer = 20.0f;

        private void Awake()
        {
            _speedRotation = Random.Range(10f, 40f);
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
                    interacted.GetComponent<Player>().SpeedGoodBonus(timer, bonusEffect);

                    CameraShake.ShakeDelegate.Invoke(0.1f);

                    Log("Ускорение передвижения");
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



