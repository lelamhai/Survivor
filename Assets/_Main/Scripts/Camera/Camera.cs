using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : BaseMonoBehaviour
{
    [SerializeField] private Transform _player = null;

    private void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        this.transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y, this.transform.position.z);
    }

    protected override void SetDefaultValue()
    {}

    protected override void LoadComponent()
    {
        _player = GameObject.Find("Player").GetComponent<Transform>();

    }
}
