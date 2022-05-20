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
            player.AddBadTimerListener(OnBadTimerChanged);
        }
        private void OnBadTimerChanged(float _badTimerStart, float badTimer)
        {
            if (badTimer / _badTimerStart > _bonusToShowBar)
            {
                badBonusTimer.value = badTimer / _badTimerStart;
                badBonusTimer.gameObject.SetActive(true);
            }
            else
            {
                badBonusTimer.gameObject.SetActive(false);
            }
        }

        public void OnDestroy()
        {
            player.RemoveBadTimerListener(OnBadTimerChanged);
        }
    }
}