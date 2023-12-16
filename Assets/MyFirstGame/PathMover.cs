using UnityEngine;

public class PathMover : MonoBehaviour
{
    [SerializeField] Transform t1, t2;
    [SerializeField] float speed;
    Transform targetTransform;

    private void Start()
    {
        transform.position = t1.position;
        targetTransform = t2;
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetTransform.position, speed * Time.deltaTime);

        if (transform.position == targetTransform.position)
            targetTransform = targetTransform == t1 ? t2 : t1;
    }
    private void OnDrawGizmos()
    {
        if (t1 == null || t2 == null) return;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(t1.position, t2.position);
    }
}
