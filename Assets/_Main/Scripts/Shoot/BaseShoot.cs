using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseShoot : BaseMonoBehaviour
{
    [SerializeField] protected bool _canShoot = true;
    [SerializeField] protected bool _isDelay = true;
    [SerializeField] protected float _timeShooting = 2f;

    private void Update()
    {
        if (!_canShoot) return;
        if (!_isDelay) return;
        StartCoroutine(Shoot());
    }

    private IEnumerator Shoot()
    {
        _isDelay = false;
        SpawnBullet();
        yield return new WaitForSeconds(_timeShooting);
        _isDelay = true;
    }

    protected abstract void SpawnBullet();
}
