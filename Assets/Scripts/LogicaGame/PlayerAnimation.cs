using UnityEngine;

namespace Scripts.GameLogica 
{
    public class PlayerAnimation : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        public PlayerAnimation(Animator animator) => _animator = animator;
        
        public void AnimationPlay(string NameAnimation, int StateAnimation) => _animator.SetInteger(NameAnimation, StateAnimation);

        public void AnimationStop() => _animator.StopPlayback();

    }
}

