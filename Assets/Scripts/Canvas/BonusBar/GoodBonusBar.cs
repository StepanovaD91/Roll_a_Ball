using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Maze
{
    public class GoodBonusBar : MonoBehaviour
    {
        [SerializeField] private Player player;
        [SerializeField] private Slider goodBonusTimer;
        [SerializeField] private float goodBonusToShowBar;


        void Start()
        {
            Subscribe();
        }

        public void Subscribe()
        {
            player.AddTimerListener(OnTimerChanged);
        }
        private void OnTimerChanged(float timer, float timerStart)
        {
            if (timer / timerStart < goodBonusToShowBar)
            {
                goodBonusTimer.gameObject.SetActive(true);
            }
            else
            {
                goodBonusTimer.gameObject.SetActive(false);
            }

        }
    }
}