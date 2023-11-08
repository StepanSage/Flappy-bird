using Scripts.Services;
using UnityEngine;

namespace Scripts.GameLogica 
{
    public class AddScoreTrigger : MonoBehaviour
    {
        private Score _score;
    
        private void Start() => _score = ServiceLocator._currentService.GetSerice<Score>();
       
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision != null)
                if (collision.GetComponent<PlayerControler>() != null)
                    _score.AddScore();    
        }
    }
}

