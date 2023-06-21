using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMoveTarget : BaseMove
{
    [SerializeField] private Transform _target = null;
    [SerializeField] private bool _isMovement = false;

    private void FixedUpdate()
    {
        if (!_isMovement) return;
        Movement();
    }

    protected override void Movement()
    {
        _currentPos = (_target.position - this.transform.position).normalized;
        this.transform.position = Vector3.MoveTowards(this.transform.position, _target.position, _moveSpeed);
    }

    public void SetFollowPlayer(Transform target, bool active)
    {
        _target = target;
        _isMovement = active;
    }
}
