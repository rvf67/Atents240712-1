using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // 실습
    // 1. 일정 시간 간격으로 적을 생성한다.
    // 2. 생성되는 범위는 화면 오른쪽 밖(높이는 -4 ~ +4)

    /// <summary>
    /// 생성할 적의 프리팹
    /// </summary>
    public GameObject enemyPrefab;

    /// <summary>
    /// 적 생성 시간간격
    /// </summary>
    public float spawnInterval = 1.0f;

    /// <summary>
    /// 최소 높이
    /// </summary>
    const float MinY = -4;

    /// <summary>
    /// 최대 높이
    /// </summary>
    const float MaxY = 4;

    //float elapedTime = 0.0f;

    private void Start()
    {
        //elapedTime = 0;
        StartCoroutine(SpawnCoroutine());   // 코루틴 시작

        //Time.timeScale = 0.1f;    // 게임 진행되는 시간의 스케일 (1일 때 원래 속도)
    }

    //private void Update()
    //{
    //    elapedTime += Time.deltaTime;
    //    if (elapedTime > spawnInterval)
    //    {
    //        elapedTime = 0.0f;
    //        Spawn();
    //    }
    //}

    /// <summary>
    /// 적을 주기적으로 스폰하는 코루틴
    /// </summary>
    /// <returns></returns>
    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            Spawn();
        }
    }

    /// <summary>
    /// 적을 하나 스폰하는 함수
    /// </summary>
    void Spawn()
    {
        Instantiate(enemyPrefab, GetSpawnPosition(), Quaternion.identity);
    }

    /// <summary>
    /// 스폰될 위치를 정해주는 함수
    /// </summary>
    /// <returns>스폰될 위치</returns>
    Vector3 GetSpawnPosition()
    {
        Vector3 result = transform.position;
        result.y = Random.Range(MinY, MaxY);
        return result;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Vector3 p0 = transform.position + Vector3.up * MaxY;
        Vector3 p1 = transform.position + Vector3.up * MinY;
        Gizmos.DrawLine(p0, p1);
    }

    private void OnDrawGizmosSelected()
    {
        // 빨간색 사각형 그리기
        
    }
}
