using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : BaseMoveTarget
{
    protected override void SetDefaultValue()
    {
        _moveSpeed = 0.02f;
    }
}
