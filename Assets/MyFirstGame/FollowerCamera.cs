using UnityEngine;

public class FollowerCamera : MonoBehaviour
{
    [SerializeField] Transform followed;
    [SerializeField] float range = 2f;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - followed.position;
    }

    void Update()
    {
        transform.position = followed.position + offset;
    }

    private void OnDrawGizmosSelected()
    {
        if (followed == null) return;
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position - offset, range);
    }
}
