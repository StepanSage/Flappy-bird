using Scripts.Services;
using TMPro;
using UnityEngine;

public class Records : MonoBehaviour
{
    [SerializeField] private TMP_Text _recordsText;

    private Save _save;
   
    void Start()
    {
        _save = ServiceLocator._currentService.GetSerice<Save>();
        _recordsText.text = _save.LoadScoreCount().ToString();
       
    }

    
}
