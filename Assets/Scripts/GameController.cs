using System;
using UnityEngine;

namespace Maze
{
    public sealed class GameController : MonoBehaviour, IDisposable
    {
        private InteractiveObject[] _interactiveObjects;

        private void Awake()
        {
            _interactiveObjects = FindObjectsOfType<InteractiveObject>();
        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObjects.Length; i++)
            {
                var interactiveObject = _interactiveObjects[i];

                if (interactiveObject == null)
                {
                    continue;
                }

                if (interactiveObject is IFly fly)
                {
                    fly.Fly();
                }
                if (interactiveObject is IFlicker flicker)
                {
                    flicker.Flick();
                }
                if (interactiveObject is IRotation rotation)
                {
                    rotation.Rotate();
                }
            }
        }

        public void Dispose()
        {
            foreach (var o in _interactiveObjects)
            {
                Destroy(o.gameObject);
            }
        }
    }
}

