using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraFollow : BaseMonoBehaviour
{
    private Vector2 _lastPos;
    private void Update()
    {
        if (IsClient && IsOwner)
        {
            InputClient();
        }
    }

    private void InputClient()
    {
        if (_lastPos == (Vector2)transform.position) return;

        CameraFollow.Instance.FollowPlayer(transform);
        _lastPos = transform.position;
    }

    protected override void SetDefaultValue()
    {}
}
