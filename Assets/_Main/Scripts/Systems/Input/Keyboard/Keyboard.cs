using UnityEngine;

public class Keyboard : BaseMonoBehaviour
{
    private Vector3 _pos = Vector2.zero;

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
    { }
}