using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        Pause.SetPause(false);
        SceneManager.LoadScene(0);
    }
}
