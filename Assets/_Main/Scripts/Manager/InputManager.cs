using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }
    public Vector2 _MovePos { get; private set; }
    private bool _isJoystick = false;

    private void Awake()
    {
        Instance = this;
    }

    public void ActiveJoystick(Vector2 currentPos, bool active)
    {
        _MovePos = currentPos;
        _isJoystick = active;
    }

    private void Update()
    {
        if (_isJoystick) return;
        Keyboard();
    }

    private void Keyboard()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        _MovePos = new Vector2(x, y);
    }
}
