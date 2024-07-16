using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01_Sprite : MonoBehaviour
{
    void Start()
    {
        // 시작할 때 한번 실행되는 함수(첫번째 업데이트 함수가 실행되기 직전에 한번 호출되는 함수)
        Debug.Log("시작");
    }

    void Update()
    {
        // 프레임마다 매번 실행되는 함수
        Debug.Log("업데이트");
    }
}
