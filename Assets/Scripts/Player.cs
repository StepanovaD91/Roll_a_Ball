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

        private float _goodTimerStart;
        private float _badTimerStart;
        public static Action<float> OnSpeedChanged;

        private Action<float, float> OnGoodTimerChanged;
        private Action<float, float> OnBadTimerChanged;

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
            _goodTimerStart = timer;
            OnGoodTimerChanged?.Invoke(_goodTimerStart, timer);

            if (_bonusRoutine != null)
            {
                StopCoroutine(_bonusRoutine);
            }
            _bonusRoutine = StartCoroutine(GoodBonusTimer(timer));
        }

        public void SpeedBadBonus(float badTimer, float speedEffect)
        {
            _badBonusSpeed = speedEffect;
            ReCalculateSpeed();
            _badTimerStart = badTimer;
            OnBadTimerChanged?.Invoke(_badTimerStart, badTimer);

            if (_bonusRoutine != null)
            {
                StopCoroutine(_bonusRoutine);
            }
            _bonusRoutine = StartCoroutine(BadBonusTimer(badTimer));

        }
        IEnumerator GoodBonusTimer(float timer)
        {
            while (timer > 0)
            {
                yield return new WaitForSeconds(1);
                timer -= 1;
                OnGoodTimerChanged(_goodTimerStart, timer);
            }
            _goodBonusSpeed = 0;
            OnGoodTimerChanged(_goodTimerStart, 0);
            ReCalculateSpeed();
        }
        IEnumerator BadBonusTimer(float badTimer)
        {
            while (badTimer > 0)
            {
                yield return new WaitForSeconds(1);
                badTimer -= 1;
                OnBadTimerChanged(_badTimerStart, badTimer);
            }
            _badBonusSpeed = 0;
            OnBadTimerChanged(_badTimerStart, 0);
            ReCalculateSpeed();
        }

        private void ReCalculateSpeed()
        {
            _speed = _baseSpeed + _goodBonusSpeed + _badBonusSpeed;

            OnSpeedChanged?.Invoke(_speed);
        }

        public void AddGoodTimerListener(Action<float, float> OnGoodTimerChanged)
        {
            OnGoodTimerChanged += OnGoodTimerChanged;
        }

        public void RemoveGoodTimerListener(Action<float, float> OnGoodTimerChanged)
        {
            OnGoodTimerChanged -= OnGoodTimerChanged;
        }

        public void AddBadTimerListener(Action<float, float> OnBadTimerChanged)
        {
            OnBadTimerChanged += OnBadTimerChanged;
        }

        public void RemoveBadTimerListener(Action<float, float> OnBadTimerChanged)
        {
            OnBadTimerChanged -= OnBadTimerChanged;
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
