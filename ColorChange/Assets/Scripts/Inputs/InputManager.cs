using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager
{
    public InputControls inputControls;

    public event Action touch;
    public InputManager()
    {
        inputControls = new InputControls();
        PlayerActionsEnable();

        inputControls.PlayerActions.Touch.performed += OnTouch;
    }

    private void OnTouch(InputAction.CallbackContext context) => touch?.Invoke();

    public void PlayerActionsEnable() => inputControls.PlayerActions.Enable();
    public void PlayerActionsDisable() => inputControls.PlayerActions.Disable();
}
