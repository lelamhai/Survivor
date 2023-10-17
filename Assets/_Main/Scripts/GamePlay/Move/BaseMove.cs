using UnityEngine;

public abstract class BaseMove : BaseMonoBehaviour
{
    [SerializeField] protected bool _canMove = false;
    [SerializeField] protected float _speed = 0.5f;
    [SerializeField] protected Vector2 _direction = Vector2.zero;

    private void LateUpdate()
    {
        if (!_canMove) return;
        Movement();
    }

    protected abstract void Movement();
}