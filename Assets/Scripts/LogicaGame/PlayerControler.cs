using Scripts.Services;
using UnityEngine;

namespace Scripts.GameLogica 
{
    public class PlayerControler : MonoBehaviour, IMove, IServices
    {
        [Header("component"), Space(5)]
        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private PlayerAnimation _playerAnimation;
        [SerializeField] private AudioClip _audioClip;
        [SerializeField] private AudioSource _audioSource;

        [Header("Setting"), Space(5)]
        [SerializeField] private int _force = 10;
        [SerializeField] private float _time = 0.8f;
        [SerializeField] private float _maxDIstansFlay;

        private float startTime;
        private bool IsFloow = default;

        private void Start()
        {
            startTime = _time;
        }

        public void Move()
        {
            _rb.velocity = Vector2.up * _force;
            IsFloow = true;
        }

        void Update()
        {
            if(Pause.IsPause) 
                return;

            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                if (transform.localPosition.y >= _maxDIstansFlay)
                {
                    transform.localPosition = new Vector3(transform.localPosition.x, _maxDIstansFlay, transform.localPosition.z);
                }
                else
                {
                    Move();
                    _audioSource.PlayOneShot(_audioClip);
                    _time = startTime;
                }

            }
            else
            {
                if (_time >= 0)
                {
                    _time -= Time.deltaTime;
                }
                else
                {
                    IsFloow = false;
                }
            }
            RotetionPlayer();

        }

        private void RotetionPlayer()
        {
            if (IsFloow)
            {
                transform.eulerAngles = new Vector3(0, 0, 20);
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, -20);
            }
        }





    }

}

