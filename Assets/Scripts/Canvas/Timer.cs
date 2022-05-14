using UnityEngine;
using System;
using UnityEngine.UI;

namespace Maze
{
    public class Timer : MonoBehaviour
    {
        public Text timerText;
        public int timeLeft = 60;
        private float gameTime;

        [SerializeField] private GameObject EndGameUI;
        [SerializeField] private GameObject MenuUI;

        void Update()
        {
            timerText.text = timeLeft + " sec";
            gameTime += 1 * Time.deltaTime;
            if (gameTime >= 1)
            {
                timeLeft--;
                gameTime = 0;
            }
            if (timeLeft < 20)
            {
                timerText.color = Color.red;
            }
            if (timeLeft == 0)
            {
                EndGameUI.gameObject.SetActive(true);
                MenuUI.gameObject.SetActive(false);
            }
        }
    }
}


