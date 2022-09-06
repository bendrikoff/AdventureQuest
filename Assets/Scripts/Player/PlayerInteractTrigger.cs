using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractTrigger : MonoBehaviour
{
    public Interactable GetSelected => _selected;

    private Interactable _selected;

    private void Start()
    {
        _selected = new EmptyInteractable();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Interactable interactable))
        {
            _selected = interactable;
            UIManager.Instance.ShowInteractLabel();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Interactable interactable))
        {
            _selected = new EmptyInteractable();
            UIManager.Instance.HideInteractLabel();
        }
    }
}
