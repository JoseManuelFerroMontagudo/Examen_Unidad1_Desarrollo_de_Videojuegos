using UnityEngine;
using UnityEngine.InputSystem; 
public class movimiento : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float moveSpeed = 5f;
    float horizontalMovement;
    public float jumpHeight = 5f;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb2D.linearVelocity = new Vector2(horizontalMovement*moveSpeed,rb2D.linearVelocity.y);
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontalMovement = context.ReadValue<Vector2>().x; 
    }
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, jumpHeight);
        }
    }
}
