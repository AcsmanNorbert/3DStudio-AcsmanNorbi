 using UnityEngine;

public class Summary : MonoBehaviour
{
    [SerializeField] int number;

    void OnValidate()
    {
        int sum = 0;
        for (int i = 1; i <= number; i++)
            sum += i;
        Debug.Log(sum);
    }
}
