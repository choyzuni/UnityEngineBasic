using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 앞으로 나아가다가 트리거 되면 자체 소멸
/// </summary>
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    private Vector3 _dir = Vector3.forward;
    private Transform _tr;
    [SerializeField] private LayerMask _enemyMask;
    [SerializeField] private int _damage = 20;
    [SerializeField] private ParticleSystem _Explosion;


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
            ParticleSystem effect = Instantiate(_Explosion, _tr.position, Quaternion.Euler(Vector3.up * 180.0f));
            Destroy(effect.gameObject, _Explosion.main.duration +
                _Explosion.main.startLifetime.constantMax);

            other.GetComponent<Enemy>().hp -= _damage;
        }

        Destroy(gameObject);
    }
}
