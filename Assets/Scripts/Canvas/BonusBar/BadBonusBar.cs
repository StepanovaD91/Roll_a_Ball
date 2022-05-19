using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Maze
{
    public class BadBonusBar : MonoBehaviour
    {
        [SerializeField] private Player player;
        [SerializeField] private Slider badBonusTimer;
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
                badBonusTimer.value = timer / _timerStart;
                badBonusTimer.gameObject.SetActive(true);
            }
            else
            {
                badBonusTimer.gameObject.SetActive(false);
            }
        }

        public void OnDestroy()
        {
            player.RemoveTimerListener(OnTimerChanged);
        }
    }
}