using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] float range = 10;
    [SerializeField] float maxImpulse = 100;
    [SerializeField] ParticleSystem particleEffect;
    [SerializeField] AudioSource audioEffect;
    [SerializeField] LayerMask layerMask;

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
        if(Physics.Raycast(mouseRay, out RaycastHit hitInfo, float.MaxValue, layerMask))
            transform.position = hitInfo.point;

        if(Input.GetMouseButtonDown(0))
            StartExplosion();
    }

    void StartExplosion()
    {
        particleEffect.Play();
        audioEffect.Play();

        Rigidbody[] allRigidBodies = FindObjectsOfType<Rigidbody>();

        Vector3 center = transform.position;
        foreach (Rigidbody rb in allRigidBodies)
        {
            Vector3 pos = rb.position;
            Vector3 distanceVector = pos - center;

            float distance = distanceVector.magnitude;
            if (distance >= range) continue;

            Vector3 direction = distanceVector / distance; //disctanceVector.normalized;

            float pushRate = 1 - (distance / range);
            Vector3 push = pushRate * maxImpulse * direction;
            rb.velocity += push / rb.mass; //rb.AddForce(push, ForceMode.Impulse);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
