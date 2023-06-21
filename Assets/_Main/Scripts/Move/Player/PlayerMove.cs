using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerMove : BaseMove
{
    [SerializeField] private Rigidbody2D _rigidbody2D = null;

    private void Update()
    {
        if (!IsOwner) return;
        MoveServerRpc();

    }

    [ServerRpc]
    public void MoveServerRpc()
    {
        Movement();
    }

    protected override void Movement()
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
