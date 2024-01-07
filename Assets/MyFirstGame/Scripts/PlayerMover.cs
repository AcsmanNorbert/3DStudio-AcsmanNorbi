using Unity.VisualScripting;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] Transform cameraTransform;
    [SerializeField] float speed;
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 cameraForward = cameraTransform.forward;
        Vector3 cameraRight = cameraTransform.right;

        Vector3 directionVector = cameraRight * x + cameraForward * z;
        directionVector.y = 0;
        //Vector3 directionVector = new(x, 0, z);// GLOBAL MOVEMENT

        directionVector.Normalize();
        Vector3 velocityVector = directionVector * speed;

        transform.position += velocityVector * speed * Time.deltaTime;

        if (directionVector != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(directionVector);

        // float angularSpeed = 360;
        // Vector3 euler = transform.rotation.eulerAngles;
        // euler.y += angularSpeed * Time.deltaTime;
        // transform.rotation = Quaternion.Euler(euler);
    }
}
