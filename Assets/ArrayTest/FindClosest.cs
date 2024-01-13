using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClosest : MonoBehaviour
{
    [SerializeField] float[] array;
    [SerializeField] float smallest;

    private void OnValidate()
    {
        if (array.Length != 0)
        {
            smallest = array[0];
            for (int i = 1; i < array.Length; i++)
                if (smallest > array[i])
                    smallest = array[i];
        }
    }
}
