using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Declarations

    [SerializeField] private float speed = 5f;
    [SerializeField] private InputRef inputRef;
    private Vector3 movement;
    public Vector2 movementDirection;

    #endregion

    void Awake(){
        inputRef.MoveEvent += Move;
    }

    void Update(){
        Movement();
    }

    private void Movement(){
        if(movementDirection.magnitude > 0.1f){
            transform.Translate(movement * speed * Time.deltaTime);
        }
    }

    private void Move(Vector2 dir){ //Input value reader
        movementDirection = dir;
        movement = new Vector3(movementDirection.x, 0, movementDirection.y);
    }

}
