using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������ ���� ������Ű�� Race_Mgr ���� �����ߴٰ� �������
/// </summary>
public class Goal_Line : MonoBehaviour
{
    [SerializeField] private Race_Mgr _raceMgr;

    private void OnTriggerEnter(Collider other)
    {
        // GetComponent �� �ش� ���� ������Ʈ�� ��� ������Ʈ�� �˻��ϴ� ���ſ� �����̹Ƿ� ȣ���� �ּ�ȭ �ؾ��Ѵ�
        Horse horse = other.GetComponent<Horse>();
        horse.doMove = false;
        _raceMgr.RegisterFinishedHorses(horse);
    }
}
