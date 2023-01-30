using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter_Fire : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _firePoint;
    [SerializeField] private float _reloadTime = 0.2f;

    private float _reloadTimer;


    private void Update()
    {
        if (_reloadTimer <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                // to do  ÃÑ¾Ë È°¼ºÈ­
                Instantiate(_bulletPrefab, _firePoint.position, Quaternion.identity);

                _reloadTimer = _reloadTime;
            }
        }
        else
        {
            _reloadTimer -= Time.deltaTime;
        }
    }
}
