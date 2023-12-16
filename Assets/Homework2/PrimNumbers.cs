using UnityEngine;

public class PrimNumbers : MonoBehaviour
{
    [SerializeField] int number;

    void OnValidate()
    {
        Debug.Log(IsPrime(number));
    }

    bool IsPrime(int num)
    {
        if (num < 2f)
            return false;

        if (num % 2 == 0)
            return false;

        for (int i = 3; i < num; i += 2)
            if (num % i == 0)
                return false;

        return true;
    }
}
