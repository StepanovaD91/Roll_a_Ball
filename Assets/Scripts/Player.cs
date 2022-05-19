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

        private float _timerStart;
        public static Action<float> OnSpeedChanged;
        private Action<float, float> OnTimerChanged;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _speed = _baseSpeed + _goodBonusSpeed;

            OnSpeedChanged?.Invoke(_speed);
        }

        public void SpeedGoodBonus(float timer, float speedEffect)
        {
            _goodBonusSpeed = speedEffect;
            ReCalculateSpeed();
            _timerStart = timer;
            OnTimerChanged?.Invoke(_timerStart, timer);

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
            _timerStart = timer;
            OnTimerChanged?.Invoke(_timerStart, timer);

            if (_bonusRoutine != null)
            {
                StopCoroutine(_bonusRoutine);
            }
            _bonusRoutine = StartCoroutine(BadBonusTimer(timer));

        }
        IEnumerator GoodBonusTimer(float timer)
        {
            while (timer > 0)
            {
                yield return new WaitForSeconds(1);
                timer -= 1;
                OnTimerChanged(_timerStart, timer);
            }
            _goodBonusSpeed = 0;
            OnTimerChanged(_timerStart, 0);
            ReCalculateSpeed();
        }
        IEnumerator BadBonusTimer(float timer)
        {
            while (timer > 0)
            {
                yield return new WaitForSeconds(1);
                timer -= 1;
                OnTimerChanged(_timerStart, timer);
            }
            _goodBonusSpeed = 0;
            OnTimerChanged(_timerStart, 0);
            ReCalculateSpeed();
        }

        private void ReCalculateSpeed()
        {
            _speed = _baseSpeed + _goodBonusSpeed + _badBonusSpeed;

            OnSpeedChanged?.Invoke(_speed);
        }

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
