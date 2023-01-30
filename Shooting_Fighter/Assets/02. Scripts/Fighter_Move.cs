using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������ �̵� ����
/// to do - �����¿� Ű�� ���� �����⸦ �̵� ��ų �� �ִ� ��ũ��Ʈ �ۼ�
/// </summary>
public class Fighter_Move : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _h;
    private float _v;
    private Transform _tr;

    private void Awake()
    {
        _tr = GetComponent<Transform>();
    }

    private void Update()
    {
        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        _tr.Translate(new Vector3(_h, 0.0f, _v).normalized * _speed * Time.fixedDeltaTime);
    }
}
