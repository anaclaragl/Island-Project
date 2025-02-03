using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Movement script along with Sebastian Graves "3RD PERSON CONTROLLER in Unity" tutorial

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;

    [SerializeField] Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;

    private void OnEnable(){
        if(playerControls == null){
            playerControls = new PlayerControls();

            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>(); //define uma lambda que le o input e atribui ao movementInputs
        }

        playerControls.Enable();
    }

    private void OnDisable(){
        playerControls.Disable();
    }

    public void HandleAllInputs(){
        HandleMovementInput();
        //handlejump
    }

    private void HandleMovementInput(){
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }
}
