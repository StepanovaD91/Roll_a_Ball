using UnityEngine;

namespace Maze
{
    public class Player : MonoBehaviour
    {
        public float _speed = 5.0f;

        [Header("Good Bonus")]
        public float _speedGoodBonus = 15.0f;
        public float _timerSpeedMaxGoodBonus = 200.0f;
        public float _timerSpeedGoodBonus;
        [Header("Bad Bonus")]
        public float _speedBadBonus = 1.0f;
        public float _timerSpeedMaxBadBonus = 100.0f;
        public float _timerSpeedBadBonus;


        private float _speedStart;
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _speedStart = _speed;
        }
        protected void TimerSpeedGoodBonus()
        {
            if (_timerSpeedGoodBonus > 0)
            {
                _speed = _speedGoodBonus;
                _timerSpeedGoodBonus--;
            }
            else
            {
                _speed = _speedStart;
            }
        }
        public void SpeedGoodBonus()
        {
            _timerSpeedGoodBonus = _timerSpeedMaxGoodBonus;
        }


        protected void TimerSpeedBadBonus()
        {
            if (_timerSpeedBadBonus > 0)
            {
                _speed = _speedBadBonus;
                _timerSpeedBadBonus--;
            }
            else
            {
                _speed = _speedStart;
            }
        }
        public void SpeedBadBonus()
        {
            _timerSpeedBadBonus = _timerSpeedMaxBadBonus;
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
