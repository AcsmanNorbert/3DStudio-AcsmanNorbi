using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] KeyCode fireButton = KeyCode.Mouse0;
    [SerializeField] GameObject bulletPrefab;

    void Update()
    {
        if(Input.GetKeyDown(fireButton))
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
        }
    }
}
