using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : BaseMonoBehaviour
{
    [SerializeField] private SpriteRenderer _model = null;
    [SerializeField] private Vector2 _currentPos = Vector2.zero;

    private void LateUpdate()
    {
        SetFlip();
    }

    private void SetFlip()
    {
        _currentPos = InputManager.Instance._MovePos;
        if (_currentPos.x != 0)
        {
            _model.flipX = _currentPos.x < 0;
        }
    }

    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        _model = this.GetComponent<SpriteRenderer>();
    }
}
