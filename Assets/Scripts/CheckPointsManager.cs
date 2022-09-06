using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointsManager : Singleton<CheckPointsManager>
{
    public Vector3 CurrentCheckPointPosition
    {
        get => _currentCheckPointPositon;
    }
    private Vector3 _currentCheckPointPositon;

    private void Start()
    {
        _currentCheckPointPositon = PlayerManager.Instance.Player.gameObject.transform.position;
    }

    public void ChangeCheckPoint(Vector3 position)
    {
        _currentCheckPointPositon = position;
    }
}
