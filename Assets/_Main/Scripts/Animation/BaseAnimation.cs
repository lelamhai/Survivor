using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAnimation : BaseMonoBehaviour
{
    [SerializeField] private Animator _animator = null;
    [SerializeField] private BaseMove _baseMove = null;
    [SerializeField] private Vector2 _currentPos = Vector2.zero;

    private void LateUpdate()
    {
        SetAnimation();
    }

    private void SetAnimation()
    {
        _currentPos = _baseMove.GetCurrentPos();
        _animator.SetFloat("Speed", _currentPos.magnitude);
    }

    protected override void SetDefaultValue()
    { }

    protected override void LoadComponent()
    {
        _animator = this.GetComponent<Animator>();
        _baseMove = this.GetComponent<BaseMove>();
    }
}
