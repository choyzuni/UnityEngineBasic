using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_Item : MonoBehaviour
{
    [SerializeField] private LayerMask _playerMask;
    [SerializeField] private float _speed = 2.0f;
    private Camera _cam;
    private Transform _tr;
    private Rigidbody _rb;


    private void Awake()
    {
        _tr = GetComponent<Transform>();
        _rb = GetComponent<Rigidbody>();
        _cam = Camera.main;
        _rb.velocity = Quaternion.Euler(Vector3.up * Random.Range(0.0f, 360.0f)) * Vector3.back * _speed;
    }

    private void FixedUpdate()
    {
        Vector3 viewPortPoint = _cam.WorldToViewportPoint(_tr.position);

        if (viewPortPoint.x < 0.0f || viewPortPoint.x > 1.0f) // ÁÂ¿ì °æ°è ºÎµúÈú¶§ ZÃà ´ëÄª º¯È¯
        {
            _rb.velocity = new Vector3(-_rb.velocity.x, -_rb.velocity.y, _rb.velocity.z);
        }
        if (viewPortPoint.y < 0.0f || viewPortPoint.y > 1.0f) // »óÇÏ °æ°è ºÎµúÈú¶§ XÃà ´ëÄª º¯È¯
        {
            _rb.velocity = new Vector3(_rb.velocity.x, -_rb.velocity.y, -_rb.velocity.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (((1 << other.gameObject.layer) & _playerMask) > 0)
        {
            Fighter_Fire.instance.bombNum++;
            Destroy(gameObject);
        }
    }
}
