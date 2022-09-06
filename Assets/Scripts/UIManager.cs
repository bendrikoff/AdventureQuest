using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private GameObject _interactLabel;
    public void ShowInteractLabel()
    {
        if(_interactLabel.activeSelf) return;
        _interactLabel.SetActive(true);
    }
    public void HideInteractLabel()
    {
        if(!_interactLabel.activeSelf) return;
        _interactLabel.SetActive(false);
    }
}
