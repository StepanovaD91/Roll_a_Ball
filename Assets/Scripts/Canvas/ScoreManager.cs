using UnityEngine;
using UnityEngine.UI;

namespace Maze
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] Text HighScoreText;
        [SerializeField] Text ScoreText;

        public static float score;
        int highscore;
        void Start()
        {
            score = 0;
        }

        void Update()
        {
            highscore = (int)score;
            ScoreText.text = "SCORE: " + highscore.ToString();

            if (PlayerPrefs.GetInt("score") <= highscore)
            {
                PlayerPrefs.SetInt("score", highscore);
            }

            HighScoreText.text = "HIGH SCORE: " + PlayerPrefs.GetInt("score").ToString();
        }
    }
}
