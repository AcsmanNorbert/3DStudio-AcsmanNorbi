using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    [SerializeField] Transform target;

    void Update()
    {
        transform.LookAt(target);   
    }
}
