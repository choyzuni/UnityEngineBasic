using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 도착한 말을 정지시키고 Race_Mgr 에게 도착했다고 등록해줌
/// </summary>
public class Goal_Line : MonoBehaviour
{
    [SerializeField] private Race_Mgr _raceMgr;

    private void OnTriggerEnter(Collider other)
    {
        // GetComponent 는 해당 게임 오브젝트의 모든 컴포넌트를 검색하는 무거운 연산이므로 호출을 최소화 해야한다
        Horse horse = other.GetComponent<Horse>();
        horse.doMove = false;
        _raceMgr.RegisterFinishedHorses(horse);
    }
}
