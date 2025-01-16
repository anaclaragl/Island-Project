using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "InputRef")]
public class InputRef : ScriptableObject, InputMap.IPlayerActions //Interfaces do Action Map
{
    private InputMap inputMap;

    void OnEnable(){ //Inicializacao do input map
        if(inputMap == null){
            inputMap = new InputMap();

            inputMap.Player.SetCallbacks(this);

            SetGameplay();
        }
    }

    public void SetGameplay(){
        inputMap.Player.Enable();
    }

    #region Events declarations

    public event Action<Vector2> MoveEvent;

    public void OnMovement(InputAction.CallbackContext context){
        MoveEvent(context.ReadValue<Vector2>());
    }

    #endregion
}
