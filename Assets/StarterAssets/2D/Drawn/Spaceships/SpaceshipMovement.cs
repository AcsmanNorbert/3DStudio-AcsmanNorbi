using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float acceleration = 5;
    [SerializeField] float angularSpeed = 360;
    [SerializeField] float gravity = 1;
    [SerializeField] float drag = 0.25f;

    Vector2 velocity = Vector2.zero;

    private void Update()
    {

        //movement
        transform.position += (Vector3)velocity * Time.deltaTime;

        //rotation
        float rotationInput = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, 0, -rotationInput * angularSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        float forwardInput = Input.GetAxisRaw("Vertical");
        //acceleration

        Vector2 direction = (Vector2)transform.up;
        Vector2 accelerationVector = direction * forwardInput * acceleration;
        velocity += accelerationVector * Time.fixedDeltaTime;

        //gravity
        velocity += Vector2.down * gravity * Time.fixedDeltaTime;
        velocity = Vector2.ClampMagnitude(velocity, maxSpeed);
        
        //drag
        Vector2 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;
    }
}
