using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void Die()
    {
        transform.position = CheckPointsManager.Instance.CurrentCheckPointPosition;
    }
}
