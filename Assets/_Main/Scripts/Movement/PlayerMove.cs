using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : BaseMonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D = null;
    [SerializeField] private Vector2 _currentPos = Vector2.zero;
    [SerializeField] private float _moveSpeed = 2f;
    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        _currentPos = InputManager.Instance._MovePos;
        _rigidbody2D.MovePosition(_rigidbody2D.position + (_currentPos * _moveSpeed * Time.deltaTime));
    }

    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        _rigidbody2D = this.GetComponent<Rigidbody2D>();
    }
}
