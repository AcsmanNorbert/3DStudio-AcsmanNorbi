using UnityEngine;
using static UnityEditor.Progress;

public class Reset : MonoBehaviour
{
    Rigidbody[] items;
    Vector3[] positions;
    Vector3[] rotations;
    private void Start()
    {
        items = GetComponentsInChildren<Rigidbody>();
        positions = new Vector3[items.Length];
        rotations = new Vector3[items.Length];
        for (int i = 0; i < items.Length; i++)
        {
            Transform transform = items[i].GetComponent<Transform>();
            positions[i] = transform.position;
            rotations[i] = transform.eulerAngles;
        }
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(items != null)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    items[i].velocity = Vector3.zero;

                    Transform transform = items[i].gameObject.GetComponent<Transform>();

                    items[i].freezeRotation = true;
                    transform.eulerAngles = rotations[i];
                    items[i].freezeRotation = false;

                    transform.position = positions[i];
                }
            }
        }
    }
}
