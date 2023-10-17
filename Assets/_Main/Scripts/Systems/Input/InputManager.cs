using UnityEngine;
using UnityEngine.Events;

public class InputManager : Singleton<InputManager>
{
    public UnityAction _Shoot;

    private Vector2 _pos = Vector2.zero;
    public Vector2 _Pos
    {
        get => _pos;
    }

    private void Update()
    {
        InputAxis();
        Shoot();
    }

    private void InputAxis()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        _pos = new Vector2(x, y);
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _Shoot?.Invoke();
        }
    }

    protected override void SetDefaultValue()
    {}
}