using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    private Vector2 _pos = Vector2.zero;
    public Vector2 _Pos
    {
        get => _pos;
    }

    private void Update()
    {
        InputAxis();
    }

    private void InputAxis()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        _pos = new Vector2(x, y);
    }

    protected override void SetDefaultValue()
    {}
}