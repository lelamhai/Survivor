using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : BaseMonoBehaviour
{
    [SerializeField] private Animator _animator = null;
    [SerializeField] private Vector2 _currentPos = Vector2.zero;

    private void LateUpdate()
    {
        SetAnimation();
    }

    private void SetAnimation()
    {
        _currentPos = InputManager.Instance._MovePos;
        _animator.SetFloat("Speed", _currentPos.magnitude);
    }

    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        _animator = this.GetComponent<Animator>();
    }
}
