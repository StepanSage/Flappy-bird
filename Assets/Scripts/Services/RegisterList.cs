using Scripts.GameLogica;
using UnityEngine;

namespace Scripts.Services 
{
    public class RegisterList : MonoBehaviour
    {
        [SerializeField] private PlayerControler _playerControler;
        [SerializeField] private Score _score;
        [SerializeField] private Save _save;

        public void Init()
        {
            ServiceLocator._currentService.Register<PlayerControler>(_playerControler);
            ServiceLocator._currentService.Register<Score>(_score);
            ServiceLocator._currentService.Register<Save>(_save);
          
        }
    }
}

