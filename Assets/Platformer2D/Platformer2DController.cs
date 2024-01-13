using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer2DController : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float horizontalSpeed = 2;
    [SerializeField] float jumpSpeed = 5;
    [SerializeField] int airJordan = 2;

    bool isGrounded;

    int airJumpBudget;

    private void OnValidate()
    {
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        Vector2 v = rigidbody.velocity;
        v.x = horizontalInput * horizontalSpeed;
        rigidbody.velocity = v;
    }

    private void Update()
    {
        bool doJump = Input.GetKeyDown(KeyCode.Space);

        bool canJump = isGrounded || airJumpBudget > 0;
        if (doJump && canJump)
        {
            Vector2 v = rigidbody.velocity;
            v.y = jumpSpeed;
            rigidbody.velocity = v;

            if(!isGrounded)
                airJumpBudget--;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        airJumpBudget = airJordan;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

    public void RefillAirJump()
    {
        airJumpBudget++;
    }
}
