using UnityEngine;
using UnityEngine.UI;

namespace Maze
{
    public class Timer : MonoBehaviour
    {
        public Text timerText;
        public int timeLeft = 60;
        private float gameTime;
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
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}


