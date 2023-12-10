using UnityEngine;

public class FiveNumbers : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;
    [SerializeField] int d;
    [SerializeField] int e;

    void OnValidate()
    {
        float average = (a + b + c + d + e) / 5f;
        Debug.Log(average);
    }
}