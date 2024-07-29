using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAsteroidSmall : EnemyBase
{
    [Header("작은 운석 데이터")]
    /// <summary>
    /// 작은 운석의 기본 속도
    /// </summary>
    float baseSpeed;

    /// <summary>
    /// 속도 범위( +-speedRandomRange )
    /// </summary>
    float speedRandomRange = 1;

    /// <summary>
    /// 작은 운석의 회전 속도
    /// </summary>
    float rotateSpeed;

    /// <summary>
    /// 작은 운석의 이동 방향
    /// </summary>
    Vector3? direction = null;

    /// <summary>
    /// 작은 운석의 이동 방향을 확인하고 설정하는 프로퍼티
    /// </summary>
    public Vector3 Direction
    {
        private get => direction.GetValueOrDefault();   // 읽기는 private
        set     // 쓰기는 public이지만 한번만 설정 가능
        {
            if (direction == null)
            {
                direction = value.normalized;
            }
        }
    }

    private void Awake()
    {
        baseSpeed = moveSpeed;  // 기준 속도는 moveSpeed를 사용
    }

    protected override void OnReset()
    {
        base.OnReset();

        moveSpeed = baseSpeed + Random.Range(-speedRandomRange, speedRandomRange);
        rotateSpeed = Random.Range(0, 360);     // 회전 속도 설정
        direction = null;           // Reset 이후에 Direction에 한번 값을 넣을 수 있도록 설정
    }

    protected override void OnMoveUpdate(float deltaTime)
    {
        transform.Translate(deltaTime * moveSpeed * Direction, Space.World);    // 초당 moveSpeed의 속도로 Direction방향으로 이동
        transform.Rotate(deltaTime * rotateSpeed * Vector3.forward);
    }
}


// 큰 운석이 터질 때 작은 운석 만들기
// 1. 죽을 때 작은 운석 생성(랜덤한 개수 min ~ max, 낮은 확률로 max의 3배로 나온다)
// 2. 생성된 작은 운석은 사방으로 퍼져나간다.(터진 큰 운석 위치를 중심으로 모든 작은 운석들이 같은 각도만큼 벌어진체로 날아간다)
