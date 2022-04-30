using System;
using UnityEngine;
using Random = UnityEngine.Random;
using static UnityEngine.Debug;

namespace Maze
{
    public sealed class RequiredBonuses : InteractiveObject, IFly
    {
        private float _lengthFly;


        private void Awake()
        {
            _lengthFly = Random.Range(0.5f, 1.2f);

        }
        public void Fly()
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, _lengthFly), transform.position.z);
        }


        protected override void Interaction(GameObject interacted)
        {
            try
            {
                if (interacted.gameObject.CompareTag("Player"))
                {
                    Log("Предметы, которые обязательно нужно собрать для победы");
                }
                ScoreManager.ScoreDelegate.Invoke(1);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

