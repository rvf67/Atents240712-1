using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test18_PlayerLife : TestBase
{
    public Transform powerUpPosition;

    public PowerUp[] powerUps;

    private void Start()
    {
        for (int i = 0; i < powerUps.Length; i++)
        {
            powerUps[i].transform.position = powerUpPosition.position + Vector3.right * i * 2;
        }
    }
}
