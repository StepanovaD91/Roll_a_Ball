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
        private float _bonusToShowBar = 0;


        public void Awake()
        {
            Subscribe();
        }

        public void Subscribe()
        {
            player.AddTimerListener(OnTimerChanged);
        }
        private void OnTimerChanged(float _timerStart, float timer)
        {
            if (timer / _timerStart > _bonusToShowBar)
            {
                goodBonusTimer.value = timer / _timerStart;
                goodBonusTimer.gameObject.SetActive(true);
            }
            else
            {
                goodBonusTimer.gameObject.SetActive(false);
            }
        }

        public void OnDestroy()
        {
            player.RemoveTimerListener(OnTimerChanged);
        }
    }
}