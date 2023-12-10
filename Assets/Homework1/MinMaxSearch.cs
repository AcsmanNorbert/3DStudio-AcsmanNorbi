 using UnityEngine;

public class MinMaxSearch : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;

    void OnValidate()
    {
        if (a == b)
            Debug.Log(a + " = " + b);
        else
        {
            if (a > b)
                Debug.Log(b + " < " + a);
            else
                Debug.Log(a + " < " + b);
        }
    }
}
