using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    TextMeshProUGUI score;

    int goalScore = 0;

    public int Score
    {
        get => goalScore;
        set
        {
            goalScore = value;
            //score.text = $"Score : {goalScore,5}";    // 5자리로 출력, 공백은 스페이스
            //score.text = $"Score : {goalScore:d5}";     // 5자리로 출력, 공백은 0으로 채우기
            score.text = $"{goalScore}";
        }
    }

    private void Awake()
    {
        Transform child = transform.GetChild(1);
        score = child.GetComponent<TextMeshProUGUI>();

        //GetComponents<TestBase>();    // 이 게임 오브젝트에 들어있는 모든 TestBase 찾기
        //TextMeshProUGUI[] result = GetComponentsInChildren<TextMeshProUGUI>();    // 자신과 자신의 모든 자식에 들어있는 TextMeshProUGUI 찾기
    }

    // 실습
    // 1. 점수가 바로 적용되는 것이 아니라 천천히 증가되게 만들어보기
    // 2. 보이는 점수와 실제 점수의 차이가 크면 클수록 빠르게 증가한다.
}
