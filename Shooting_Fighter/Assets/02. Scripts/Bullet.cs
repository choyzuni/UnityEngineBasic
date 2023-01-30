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
        Destroy(gameObject);
    }
}
