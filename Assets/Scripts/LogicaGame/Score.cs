using Scripts.Services;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Scripts.GameLogica 
{
    public class Score : MonoBehaviour, IServices
    {
        [SerializeField] private TMP_Text _text;

       

        public int ScoreCount { get; private set; }

       
        public void AddScore()
        {
            ScoreCount++;
            WriteScore(ScoreCount);
        }

        void Start()
        {
           
            WriteScore(ScoreCount);
        }

        private void WriteScore(int score) => _text.text = score.ToString();       
        

    }
}

