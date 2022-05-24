using UnityEngine;
using System;
using UnityEngine.UI;


namespace Maze
{
    public class SpeedUI : MonoBehaviour
    {
        [SerializeField] Text SpeedText;

        public void Awake()
        {
            Subscribe();
        }

        public void Subscribe()
        {
            Player.OnSpeedChanged += OnSpeedChanged;
        }

        private void OnSpeedChanged(float speed)
        {
            SpeedText.text = speed.ToString();
            if (speed < 5)
            {
                SpeedText.color = Color.red;
            }
            if (speed == 5)
            {
                SpeedText.color = Color.black;
            }
            if (speed > 5)
            {
                SpeedText.color = Color.green;
            }
        }

        private void OnDestroy()
        {
            Player.OnSpeedChanged -= OnSpeedChanged;
        }

    }
}