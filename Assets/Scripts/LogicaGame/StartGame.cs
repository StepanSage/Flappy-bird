using Scripts.GameLogica;
using Scripts.Services;
using UnityEngine;

namespace Scripts.GameLogica 
{
    public class StartGame : MonoBehaviour
    {
        private PlayerControler _playerControler;

        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private GameObject[] _columns;
        [SerializeField] private Enemy _platform;
        [SerializeField] private GameObject _currsor;

        private void Start() => _playerControler = ServiceLocator._currentService.GetSerice<PlayerControler>();
   
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                _playerControler.enabled = true;
                _playerControler.Move();
                _rb.gravityScale = 2f;
                _platform.enabled = true;

                for (int i = 0; i < _columns.Length; i++)
                {
                    _columns[i].SetActive(true);
                }

                Destroy(_currsor);
                Destroy(gameObject);
            }
        }

    }

}

