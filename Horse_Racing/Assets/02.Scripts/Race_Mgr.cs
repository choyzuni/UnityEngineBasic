using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 경주 로직을 관리하는 클래스
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
    /// 경주 시작 : 말들을 출발시킴
    /// </summary>
    public void StartRace()
    {
        for (int i = 0; i < _horses.Length; i++)
        {
            _horses[i].doMove = true;
        }
    }

    /// <summary>
    /// 경주 끝 : 1, 2, 3등을 UI창에 띄워줌
    /// </summary>
    public void StopRace()
    {
        for (int i = 0; i < _followCams.Length; i++)
        {
            // 남는 카메라는 놀게 함
            if (i > _finishedHorses.Count - 1)
            {
                break;
            }

            _followCams[i].target = _finishedHorses[i].transform;
        }

        _finishedUI.SetActive(true);
    }

    /// <summary>
    /// 골 라인에 도착한 말을 등록시킴
    /// </summary>
    /// <param name="horse"> 골 라인에 도착한 말 </param>
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
    /// 경주가 끝나는 조건을 체크하고 경주를 끝냄
    /// </summary>
    private void CheckRaceFinished()
    {
        if (_horses.Length == _finishedHorses.Count)
        {
            StopRace();
        }
    }
}
