using UnityEngine;

public class NumericTable : MonoBehaviour
{
    //Raktam bele egy switch-et hogy szeretnénk-e ismétlõdõ szorzatokat
    [SerializeField] bool duplicates;

    void OnValidate()
    {
        if (duplicates)
            for (int i = 1; i <= 10; i++)
                for (int e = 1; e <= 10; e++)
                    Debug.Log(i + " * " + e + " = " + i * e);
        else
            for (int i = 1; i <= 10; i++)
                for (int e = i; e <= 10; e++)
                    Debug.Log(i + " * " + e + " = " + i * e);
    }
}
