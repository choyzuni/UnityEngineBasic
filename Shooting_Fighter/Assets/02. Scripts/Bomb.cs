using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 앞으로 나아가다가 트리거 되면 자체 소멸
/// </summary>
public class Bomb : MonoBehaviour
{
    [SerializeField] private float _speed = 6.0f;
    private Vector3 _dir = Vector3.forward;
    private Transform _tr;
    [SerializeField] private LayerMask _enemyMask;
    [SerializeField] private int _damage = 50;
    [SerializeField] private float _range = 2.5f;
    [SerializeField] private ParticleSystem _effect;


    // ==========================================
    //                private methods
    // ==========================================

    private void Awake()
    {
        _tr = GetComponent<Transform>();

    }

    private void FixedUpdate()
    {
        _tr.Translate(_dir * _speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (((1 << other.gameObject.layer) & _enemyMask) > 0)
        {
            ParticleSystem effect = Instantiate(_effect, _tr.position, Quaternion.identity);
            Destroy(effect.gameObject, _effect.main.duration +
                _effect.main.startLifetime.constantMax);

            foreach (Collider enemy in Physics.OverlapSphere(_tr.position, _range, _enemyMask))
            {
                enemy.GetComponent<Enemy>().hp -= _damage;
                //(int)(1.0f - Vector3.Distance(_tr.position,
                //    enemy.transform.position / _range)) * _damage;
            }
        }

        Destroy(gameObject);
    }
}
