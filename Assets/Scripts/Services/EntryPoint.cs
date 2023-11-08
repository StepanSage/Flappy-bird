using UnityEngine;

namespace Scripts.Services 
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private RegisterList _registerList;
        private void Awake()
        {
           ServiceLocator.Init();
            _registerList.Init();
        }
    }
}

