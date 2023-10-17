using Unity.Netcode;
using UnityEngine;

public class EnemyMove : BaseMove
{
    [SerializeField] private Transform _player;

    public Vector2 _Direction
    {
        get => _direction;
    }

    private void Start()
    {
        //_player = GameObject.Find("Farmer_0").transform;
    }

    protected override void Movement()
    {
        if (_player == null) return;

        _direction = this.transform.position - _player.position;
        this.transform.position = Vector3.MoveTowards(this.transform.position, _player.position, _speed * Time.fixedDeltaTime);
    }

    protected override void SetDefaultValue()
    {
        _speed = 1f;
    }
}
