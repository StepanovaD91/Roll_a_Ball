using UnityEngine;
using System;
using UnityEngine.UI;

namespace Maze
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] Text HighScoreText;
        [SerializeField] Text ScoreText;

        [SerializeField] private float score;
        private int _currentScore;
        private int _maxScore;

        public static Action<int> ScoreDelegate;
        void Start()
        {
            ScoreDelegate += AddScore;
            _currentScore = 0;
        }

        private void AddScore(int val)
        {
            _currentScore += val;
            ScoreText.text = "SCORE: " + _currentScore.ToString();

            _maxScore = PlayerPrefs.GetInt("score");
            if (_maxScore <= _currentScore)
            {
                PlayerPrefs.SetInt("score", _currentScore);
            }

            HighScoreText.text = "HIGH SCORE: " + PlayerPrefs.GetInt("score").ToString();
        }

    }
}
