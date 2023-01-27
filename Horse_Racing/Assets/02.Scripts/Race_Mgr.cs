using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� ������ �����ϴ� Ŭ����
/// </summary>
public class Race_Mgr : MonoBehaviour
{
    [SerializeField] private Horse[] _horses;
    [SerializeField] private Target_Follow_Cam[] _followCams;
    [SerializeField] private GameObject _finishedUI;
    private List<Horse> _finishedHorses = new List<Horse>();


    //==========================================================
    //                     Public Method
    //==========================================================

    /// <summary>
    /// ���� ���� : ������ ��߽�Ŵ
    /// </summary>
    public void StartRace()
    {
        for (int i = 0; i < _horses.Length; i++)
        {
            _horses[i].doMove = true;
        }
    }

    /// <summary>
    /// ���� �� : 1, 2, 3���� UIâ�� �����
    /// </summary>
    public void StopRace()
    {
        for (int i = 0; i < _followCams.Length; i++)
        {
            // ���� ī�޶�� ��� ��
            if (i > _finishedHorses.Count - 1)
            {
                break;
            }

            _followCams[i].target = _finishedHorses[i].transform;
        }

        _finishedUI.SetActive(true);
    }

    /// <summary>
    /// �� ���ο� ������ ���� ��Ͻ�Ŵ
    /// </summary>
    /// <param name="horse"> �� ���ο� ������ �� </param>
    public void RegisterFinishedHorses(Horse horse)
    {
        if (_finishedHorses.Contains(horse))
        {
            Debug.LogWarning($"Race_Mgr : {horse.name} is already arrived");
            return;
        }

        _finishedHorses.Add(horse);

        CheckRaceFinished();
    }


    //==========================================================
    //                     Private Method
    //==========================================================

    /// <summary>
    /// ���ְ� ������ ������ üũ�ϰ� ���ָ� ����
    /// </summary>
    private void CheckRaceFinished()
    {
        if (_horses.Length == _finishedHorses.Count)
        {
            StopRace();
        }
    }
}
