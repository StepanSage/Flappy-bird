using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scripts.GameLogica
{
    public class LoseGame : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision != null)
            {
                if (collision.gameObject.GetComponent<Enemy>())
                {
                    SceneManager.LoadScene(0);
                }
            }
        }
    }
}

