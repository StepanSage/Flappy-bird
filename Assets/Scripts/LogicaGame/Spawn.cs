using UnityEngine;

namespace Scripts.GameLogica 
{
    public class Spawn : MonoBehaviour
    {
        [SerializeField] private Vector2 _endPosition;
        [SerializeField] private Vector2 _startPosition;
        [SerializeField] private Transform _midPosotion;

        private void Update()
        {
            if (transform.localPosition.x <= _endPosition.x)
            {
                transform.localPosition = _startPosition;  
            }
        }

        private void Start() => _midPosotion = transform;
    }
}

