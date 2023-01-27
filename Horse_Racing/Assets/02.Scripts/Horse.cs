using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 안정성에 따른 속도로 전진하는 말
/// </summary>
public class Horse : MonoBehaviour
{
    public bool doMove;

    [SerializeField] private float _speed = 2.0f;
    [Range(0.0f, 1.0f)]
    [SerializeField] private float _stability = 0.7f;


    //==========================================================
    //                     Private Method
    //==========================================================

    // 고정 프레임당 한번 호출
    // 거리 변화량 = ( 속도 ) * 시간 변화량 ( Vector3.forward * randomSpeed ) * Time.fixedDeltaTime
    private void FixedUpdate()
    {
        if (doMove)
        {
            Move();
        }
    }

    private void Move()
    {
        float randomSpeed = _speed * Random.Range(_stability, 1.0f);
        transform.Translate(Vector3.forward * randomSpeed * Time.fixedDeltaTime);
    }
}
