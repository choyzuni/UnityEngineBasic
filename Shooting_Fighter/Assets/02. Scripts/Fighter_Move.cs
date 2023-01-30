using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 전투기 이동 제어
/// to do - 상하좌우 키를 통해 전투기를 이동 시킬 수 있는 스크립트 작성
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
