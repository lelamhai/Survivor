using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel : BaseModel
{
    [SerializeField] private EnemyMove _enemyMove;

    private void LateUpdate()
    {
        if (_enemyMove._Direction.x != 0)
        {
            _spriteRenderer.flipX = _enemyMove._Direction.x > 0;
        }
    }

    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadMove();
    }

    private void LoadMove()
    {
        _enemyMove = this.transform.GetComponent<EnemyMove>();
    }
}
