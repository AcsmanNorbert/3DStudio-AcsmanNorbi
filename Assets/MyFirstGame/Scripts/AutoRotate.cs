using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField] float angularSpeed = 360;

    void Update()
    {
        Vector3 rotationSpeed = Vector3.up * Time.deltaTime * angularSpeed + transform.eulerAngles;
        if (rotationSpeed.y >= 360f)
            rotationSpeed.y -= 360f;
        transform.eulerAngles = rotationSpeed;
    }
}
