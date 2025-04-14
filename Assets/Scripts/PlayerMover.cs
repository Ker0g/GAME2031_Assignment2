using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private Vector3 moveDirection = Vector3.zero;

    private float moveSpeed = 1000;
    private float maxSpeed = 10.0f;
    private float jumpForce = 333.0f;
    private float normalizedSpeed => Mathf.Abs(rb.linearVelocityX / maxSpeed);

    private Rigidbody2D rb;
   
    private SpriteRenderer spriteRenderer;

    private bool isTurning = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        AddMoveForce();
        
    }

    public void Move(Vector2 direction)
    {
        moveDirection = direction;
    }

    private void AddMoveForce()
    {
        if (rb.linearVelocity.magnitude >= maxSpeed)
            return;

        rb.AddForce(moveDirection * moveSpeed * Time.fixedDeltaTime);
    }

    

    public void FlipX()
    {
        spriteRenderer.flipX = !spriteRenderer.flipX;
        isTurning = false;
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce);

        
    }

}
