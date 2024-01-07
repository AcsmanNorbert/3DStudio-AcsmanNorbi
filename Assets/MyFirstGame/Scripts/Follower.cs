using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] Transform targetTransform;

    void Update()
    {
        Vector3 selfPosition = transform.position;
        Vector3 targetPosition = targetTransform.position;

        transform.position = Vector3.MoveTowards(selfPosition, targetPosition, speed * Time.deltaTime);

        Vector3 directionVector = targetPosition - selfPosition;
        directionVector.Normalize();

        //Vector3 velocityVector = directionVector * speed * Time.deltaTime;
        //transform.position += velocityVector;

        if (directionVector != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(directionVector);
    }
}
