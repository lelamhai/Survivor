using UnityEngine;

public class BulletMove : BaseMove
{
    protected override void Movement()
    {
        this.transform.Translate(_direction * _speed * Time.deltaTime);
    }

    protected override void SetDefaultValue()
    {
        SetDirection();
        SetSpeed();
        SetCanMove();
    }

    private void SetDirection()
    {
        _direction = Vector2.right;
    }

    private void SetSpeed()
    {
        _speed = 7f;
    }
    private void SetCanMove()
    {
        _canMove = true;
    }
}