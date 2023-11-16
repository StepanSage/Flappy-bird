using Scripts.Services;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scripts.GameLogica
{
    public class LoseGame : MonoBehaviour
    {

        [SerializeField] private GameObject _restart;
        private Save _save;



        private void Start()
        {
            _save = ServiceLocator._currentService.GetSerice<Save>();
            
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision != null)
            {
                if (collision.gameObject.GetComponent<Enemy>())
                {
                    _save.SaveGame();
                   _restart.SetActive(true);
                    Pause.SetPause(true);
                }
            }
        }
    }
}

