using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    public Player PlayerInput;

    private void Awake()
    {
        instance = this;
        PlayerInput = new Player();
    }

    private void OnEnable()
    {
        PlayerInput.Enable();
    }

    private void Ondisable()
    {
        PlayerInput.Disable();
    }
}
