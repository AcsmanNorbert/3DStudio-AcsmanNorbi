using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] Transform targetTransform;

    void Update()
    {
        Vector3 selfPosition = transform.position;
        Vector3 targetPosition = targetTransform.position;

        Vector3 directionVector = targetPosition - selfPosition;
        directionVector.Normalize();

        Vector3 velocityVector = directionVector * speed;

        transform.position += velocityVector * speed * Time.deltaTime;

        if (directionVector != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(directionVector);
    }
}
