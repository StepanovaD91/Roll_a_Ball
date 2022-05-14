using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Maze
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _speed = 5.0f;
        private float _goodBonusSpeed = 0f;
        private float _badBonusSpeed = 0f;

        private Rigidbody _rigidbody;
        private float _baseSpeed = 5.0f;
        private Coroutine _bonusRoutine;

        private Action<float, float> OnTimerChanged;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _speed = _baseSpeed + _goodBonusSpeed;
        }

        public void SpeedGoodBonus(float timer, float speedEffect)
        {
            _goodBonusSpeed = speedEffect;
            ReCalculateSpeed();

            //  OnTimerChanged?.Invoke(timerStart, timer);

            if (_bonusRoutine != null)
            {
                StopCoroutine(_bonusRoutine);
            }
            _bonusRoutine = StartCoroutine(GoodBonusTimer(timer));
        }
        public void SpeedBadBonus(float timer, float speedEffect)
        {
            _badBonusSpeed = speedEffect;
            ReCalculateSpeed();

            //  OnTimerChanged?.Invoke(timerStart, timer);

            if (_bonusRoutine != null)
            {
                StopCoroutine(_bonusRoutine);
            }
            _bonusRoutine = StartCoroutine(BadBonusTimer(timer));
        }
        IEnumerator GoodBonusTimer(float timer)
        {
            yield return new WaitForSeconds(timer);
            _goodBonusSpeed = 0;
            ReCalculateSpeed();
        }
        IEnumerator BadBonusTimer(float timer)
        {
            yield return new WaitForSeconds(timer);
            _badBonusSpeed = 0;
            ReCalculateSpeed();
        }

        private void ReCalculateSpeed()
        {
            _speed = _baseSpeed + _goodBonusSpeed + _badBonusSpeed;
        }

        /* public virtual void OnBonusTimer()
         {
             OnTimerChanged?.Invoke(timerStart, timer);
         }*/

        public void AddTimerListener(Action<float, float> onTimerChanged)
        {
            OnTimerChanged += onTimerChanged;
        }

        public void RemoveTimerListener(Action<float, float> onTimerChanged)
        {
            OnTimerChanged -= onTimerChanged;
        }
        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _rigidbody.AddForce(movement * _speed);
        }

    }
}
