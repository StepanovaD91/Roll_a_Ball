
using UnityEngine;
using Random = UnityEngine.Random;
using static UnityEngine.Debug;

namespace Maze
{
    public sealed class GoodBonuses : InteractiveObject, IRotation
    {
        private float _speedRotation;

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

            if (interacted.gameObject.tag == "Player")
            {
                interacted.GetComponent<Player>().SpeedGoodBonus();
                Log("Ускорение передвижения");
            }
        }
    }
}



