using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAttack : BaseMonoBehaviour
{
    [SerializeField] protected bool _canShoot = true;
    [SerializeField] protected bool _isDelay = true;
    [SerializeField] protected float _timeShooting = 2f;
    [SerializeField] protected Transform _point = null;

    private void FixedUpdate()
    {
        if (!_canShoot) return;
        if (!_isDelay) return;
        StartCoroutine(Shoot());
    }

    private IEnumerator Shoot()
    {
        _isDelay = false;
        AttackBullet();
        yield return new WaitForSeconds(_timeShooting);
        _isDelay = true;
    }


    protected abstract void AttackBullet();
}