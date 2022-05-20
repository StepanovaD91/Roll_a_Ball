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
            player.AddGoodTimerListener(OnGoodTimerChanged);
        }
        private void OnGoodTimerChanged(float _goodTimerStart, float timer)
        {
            if (timer / _goodTimerStart > _bonusToShowBar)
            {
                goodBonusTimer.value = timer / _goodTimerStart;
                goodBonusTimer.gameObject.SetActive(true);
            }
            else
            {
                goodBonusTimer.gameObject.SetActive(false);
            }
        }

        public void OnDestroy()
        {
            player.RemoveGoodTimerListener(OnGoodTimerChanged);
        }
    }
}