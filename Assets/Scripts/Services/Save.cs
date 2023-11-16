using Scripts.GameLogica;
using Scripts.Services; 
using UnityEngine;

public class Save : MonoBehaviour, IServices
{
    private  Score _score;

    private void Start()
    {
        _score = ServiceLocator._currentService.GetSerice<Score>(); 
    }

    public  void SaveGame()
    {
       if(_score.ScoreCount > PlayerPrefs.GetInt("Score"))
       {
            SaveScore();
       }
       
    }

    public  int LoadScoreCount()
    {
        return PlayerPrefs.GetInt("Score");
    }

    private  void SaveScore()
    {
        PlayerPrefs.SetInt("Score", _score.ScoreCount);
    }
}
