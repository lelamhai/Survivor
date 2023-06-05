using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }
    public Vector2 _MovePos { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void FixedUpdate()
    {
        MoveKeyboardInput();
    }

    private void MoveKeyboardInput()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        _MovePos = new Vector2(x, y);
    }
    
    private void Joytick()
    {

    }    
}
