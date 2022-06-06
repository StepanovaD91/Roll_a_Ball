using System.Collections;
using System;
using UnityEngine;
using Random = UnityEngine.Random;
using static UnityEngine.Debug;
using System.IO;

namespace Maze
{
    public class BadBonuses : InteractiveObject, IFlicker, IRotation
    {
        [SerializeField] public MeshRenderer _meshRenderer;
        private float _lengthFly;
        private float _speedRotation;

        [SerializeField] private float bonusEffect = -5.0f;
        [SerializeField] private float badTimer = 10.0f;

        SerializableXMLData<SaveDataBadBonus> _serializableXMLData = new SerializableXMLData<SaveDataBadBonus>();
        private void Awake()
        {
            _speedRotation = Random.Range(2f, 50f);

            /*SaveDataBadBonus saveData = new SaveDataBadBonus();
            File.WriteAllText(path, Crypto.CryptoXOR(str));

            saveData.Position = transform.position;
            saveData.SpeedRotation = _speedRotation;
            saveData.LengthFly = _lengthFly;
            saveData.BonusEffect = bonusEffect;
            saveData.BadTimer = badTimer;

            var path = Path.Combine(Application.streamingAssetsPath, gameObject.name);

            _serializableXMLData.Save(saveData, path);*/
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

        public (float speedBonus, float timerBonus) GetBonus()
        {
            return (bonusEffect, badTimer);
        }

        protected override void Interaction(GameObject interacted)
        {
            try
            {
                if (interacted.gameObject.CompareTag("Player"))
                {
                    interacted.GetComponent<Player>().SpeedBadBonus(badTimer, bonusEffect);

                    CameraShake.ShakeDelegate.Invoke(0.25f);
                    
                    (float speedBonus, float timerBonus) getBonus = (bonusEffect, badTimer);
                    Log($"{getBonus.speedBonus}/{getBonus.timerBonus}");
                    
                    Log("Замедление передвижения");
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