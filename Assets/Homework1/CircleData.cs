using UnityEngine;

public class CircleData : MonoBehaviour
{
    [SerializeField] float r;

    void OnValidate()
    {
        float circumference = 2 * r * Mathf.PI;
        Debug.Log("Kerület: " + circumference);
        float area = r * r * Mathf.PI; //vagy float area = Mathf.Pow(r, 2f) * Mathf.PI;
        Debug.Log("Terület: " + area);
    }
}
