using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public abstract class BaseMove : BaseMonoBehaviour
{
    [SerializeField] protected Vector2 _currentPos = Vector2.zero;
    [SerializeField] protected float _moveSpeed = 2f;

    public Vector2 GetCurrentPos()
    {
        return _currentPos;
    }

    protected abstract void Movement();
}
