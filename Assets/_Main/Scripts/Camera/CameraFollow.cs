using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : BaseMonoBehaviour
{
    [SerializeField] private Transform _player = null;
    private Vector3 _lastPos = Vector3.zero;

    private void Start()
    {
        _lastPos = _player.transform.position;
    }

    private void Update()
    {
        if (_lastPos == _player.position) return;
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        this.transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y, this.transform.position.z);
        _lastPos = _player.transform.position;
    }

    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        _player = GameObject.Find("Player").GetComponent<Transform>();
    }
}
