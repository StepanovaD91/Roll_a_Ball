using System.Collections;
using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Maze
{
    public class CameraShake : MonoBehaviour
    {
        public static Action<float> ShakeDelegate;
        void Start()
        {
            ShakeDelegate += AddEvent;
        }

        private void AddEvent(float duration)
        {
            StartCoroutine(Shake(duration, 0.15f));
        }

        IEnumerator Shake(float duration, float magnitude)
        {
            Vector3 originalPos = transform.localPosition;
            float elapsed = 0.0f;

            while (elapsed < duration)
            {
                float x = Random.Range(-1f, 1f) * magnitude;
                float y = Random.Range(-1f, 1f) * magnitude;

                transform.localPosition = new Vector3(x, y, originalPos.z);

                elapsed += Time.deltaTime;

                yield return null;
            }

            transform.localPosition = originalPos;
        }

        void OnDestroy()
        {
            ShakeDelegate += AddEvent;
        }
    }
}

