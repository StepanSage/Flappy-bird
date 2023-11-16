using UnityEngine;

namespace Scripts.GameLogica 
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private float _speed;

        void Update()
        {
            if (Pause.IsPause)
                return;

            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
    }
}

