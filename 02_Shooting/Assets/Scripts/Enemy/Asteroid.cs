using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private void Update()
    {
        //transform.Rotate(0, 0, Time.deltaTime * 360);             // x,y,z를 따로 받기
        //transform.Rotate(Time.deltaTime * 360 * Vector3.forward); // Vector3로 받기
        //transform.Rotate(Vector3.forward, Time.deltaTime * 360);  // 축과 축을 중심으로 얼마나 회전할지를 받기
    }

    // 빙글빙글 돌면서 왼쪽으로 이동시키기
}
