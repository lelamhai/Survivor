using UnityEngine;

public abstract class BaseMove : BaseMonoBehaviour
{
    [SerializeField] protected float _speed = 0.5f;

    protected abstract void Movement();
}