using UnityEngine;

public class PlayerMove : BaseMove
{
    [SerializeField] private Rigidbody2D _rigidbody2D;

    private void LateUpdate()
    {
        Movement();
    }

    protected override void Movement()
    {
        Vector2 nextVector = InputManager.Instance._Pos.normalized * _speed * Time.fixedDeltaTime;
        _rigidbody2D.MovePosition(_rigidbody2D.position + nextVector);
    }

    protected override void SetDefaultValue()
    {
        _speed = 2f;
    }

    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadRigidbody();
    }

    private void LoadRigidbody()
    {
        _rigidbody2D = this.transform.GetComponent<Rigidbody2D>();
    }
}