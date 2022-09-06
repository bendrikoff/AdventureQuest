using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerManager : Singleton<PlayerManager>
{
    public Player Player
    {
        get => _player;
    }

    private Player _player;

    protected override void Awake()
    {
        base.Awake();
        
        _player = FindObjectOfType<Player>().GetComponent<Player>();
    }
}
