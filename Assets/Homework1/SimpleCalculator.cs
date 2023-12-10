using UnityEngine;

public class SimpleCalculator : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;

    void OnValidate()
    {
        float sum = a + b;
        Debug.Log(a + " + " + b + " = " + sum);

        float dif1 = a - b;
        float dif2 = b - a;
        Debug.Log(a + " - " + b + " = " + dif1 + " és " + b + " - " + a + " = " + dif2);

        float mult = a * b;
        Debug.Log(a + " * " + b + " = " + mult);

        float div1 = a / b;
        float div2 = b / a;
        Debug.Log(a + " / " + b + " = " + div1 + " és " + b + " / " + a + " = " + div2);
    }
}
