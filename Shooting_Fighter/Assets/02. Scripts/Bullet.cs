using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������ ���ư��ٰ� Ʈ���� �Ǹ� ��ü �Ҹ�
/// </summary>
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    private Vector3 _dir = Vector3.forward;
    private Transform _tr;
    [SerializeField] private LayerMask _enemyMask;
    [SerializeField] private int _damage = 20;


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
            other.GetComponent<Enemy>().hp -= _damage;
        }

        Destroy(gameObject);
    }
}
