using UnityEngine;

public class SmallestMultiply : MonoBehaviour
{
    int LeastCommonMultiply(int a, int b)
    {
        int max = Mathf.Max(a, b);
        int min = Mathf.Min(a, b);

        for (int i = max; i > 0; i += max)
            if (i % min == 0)
                return i;
        return -1;
    }
}
