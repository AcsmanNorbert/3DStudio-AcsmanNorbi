using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float maxDistance = 1000;
    [SerializeField] float maxLifeTime = 1000;

    Vector3 startPosition;
    float startTime;
    private void Start()
    {
        startPosition = transform.position;
        startTime = Time.time;
    }

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        float currentDistance = Vector3.Distance(transform.position, startPosition);
        float currentAge = Time.time - startTime;
        if (currentDistance >= maxDistance || currentAge > maxLifeTime)
            Destroy(gameObject);
    }
}
