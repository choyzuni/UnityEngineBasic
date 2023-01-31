using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    [SerializeField] private Enemy_Move _enemyPrefab;
    [SerializeField] private Transform _target;
    [SerializeField] private float _spawnRange = 20.0f;
    [SerializeField] private float _spawnDelay = 1.0f;
    [SerializeField] private float _targetFollowRate = 0.7f;

    private float _timer;


    private void Update()
    {
        Spawn();
    }


    private void Spawn()
    {
        if (_timer <= 0)
        {
            // 삼항 연산자 = ㅇㅇ 이라면 ? A : B
            Instantiate(original: _enemyPrefab,
                        position: transform.position + new Vector3(
                            Random.Range(-_spawnRange / 2.0f, +_spawnRange / 2.0f), 0.0f, 0.0f),
                        rotation: Quaternion.Euler(0.0f, 180.0f, 0.0f))
                .target = Random.Range(0.0f, 1.0f) < 0.7f ? _target : null;

            _timer = _spawnDelay;
        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }

}
