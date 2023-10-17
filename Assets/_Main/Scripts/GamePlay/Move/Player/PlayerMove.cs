using Unity.Netcode;
using UnityEngine;

public class PlayerMove : BaseMove
{
    [SerializeField] private Rigidbody2D _rigidbody2D;

    protected override void Movement()
    {
        Vector2 nextVector = InputManager.Instance._Pos.normalized * _speed * Time.fixedDeltaTime;
        _rigidbody2D.MovePosition(_rigidbody2D.position + nextVector);
    }

    protected override void SetDefaultValue()
    {
        SetSpeed();
        SetCanMove();
        LoadRigidbody();
    }

    private void SetSpeed()
    {
        _speed = 2f;
    }

    private void SetCanMove()
    {
        _canMove = true;
    }

    private void LoadRigidbody()
    {
        _rigidbody2D = this.transform.GetComponent<Rigidbody2D>();
    }
}