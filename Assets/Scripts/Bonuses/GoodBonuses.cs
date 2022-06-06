using System;
using UnityEngine;
using Random = UnityEngine.Random;
using static UnityEngine.Debug;
using System.IO;


namespace Maze
{
    public sealed class GoodBonuses : InteractiveObject, IRotation
    {
        private float _speedRotation;
        [SerializeField] private float bonusEffect = 5.0f;
        [SerializeField] private float timer = 20.0f;
        [SerializeField] private bool _isAllowScaling;


        SerializableXMLData<SaveDataGoodBonus> _serializableXMLData = new SerializableXMLData<SaveDataGoodBonus>();
        private void Awake()
        {
            _speedRotation = Random.Range(10f, 40f);

            /*SaveDataGoodBonus saveData = new SaveDataGoodBonus();
            saveData.Position = transform.position;
            saveData.SpeedRotation = _speedRotation;
            saveData.BonusEffect = bonusEffect;
            saveData.Timer = timer;

            var path = Path.Combine(Application.streamingAssetsPath, gameObject.name);

            _serializableXMLData.Save(saveData, path);*/

        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawIcon(transform.position, "icon.png", _isAllowScaling);
        }


        public void Rotate()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }

        public (float speedBonus, float timerBonus) GetBonus()
        {
            return (bonusEffect, timer);
        }

        protected override void Interaction(GameObject interacted)
        {
            try
            {
                if (interacted.gameObject.CompareTag("Player"))
                {
                    interacted.GetComponent<Player>().SpeedGoodBonus(timer, bonusEffect);

                    CameraShake.ShakeDelegate.Invoke(0.1f);

                    (float speedBonus, float timerBonus) getBonus = (bonusEffect, timer);
                    Log($"{getBonus.speedBonus}/{getBonus.timerBonus}");
                    
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



