using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : BaseMove
{
    [SerializeField] private Transform _player;
    [SerializeField] private bool _isMovement = false;
    [SerializeField] private Vector2 _direction = Vector2.zero;
    public Vector2 _Direction
    {
        get => _direction;
    }

    private void Start()
    {
        _player = GameObject.Find("Player").transform;
    }

    private void FixedUpdate()
    {
        if (!_isMovement) return;
        Movement();
    }

    protected override void Movement()
    {
        _direction = this.transform.position - _player.position;
        this.transform.position = Vector3.MoveTowards(this.transform.position, _player.position, _speed * Time.fixedDeltaTime);
    }

    protected override void SetDefaultValue()
    {
        _speed = 1f;
    }
}
