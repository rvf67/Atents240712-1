using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    Player player;

    /// <summary>
    /// 씬에 있는 플레이어에 접근하기 위한 프로퍼티(읽기전용)
    /// </summary>
    public Player Player
    {
        get
        {
            if(player == null)
            {
                OnInitialize(); // OnInitialize전에 호출되면 일단 초기화먼저 처리
            }
            return player;
        }
    }

    protected override void OnInitialize()
    {
        player = FindAnyObjectByType<Player>();
    }
}
