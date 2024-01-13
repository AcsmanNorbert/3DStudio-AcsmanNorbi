using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] int arrayLenght;
    [SerializeField] int[] array1 = new int[3];
    [SerializeField] int[] array2 = new int[3];
    [SerializeField] int[] array3 = new int[3];
    [SerializeField] int[] array4; int array4lenght = 15;

    void OnValidate()
    {
        for (int i = 0; i < arrayLenght; i++)
            array1[i] = i + 1;

        for (int i = 0; i < arrayLenght; i++)
            array2[i] = arrayLenght - i;

        for (int i = 0; i < arrayLenght; i++)
            array3[i] = (i + 1) * 3;

        int lenght4 = array4lenght / 3;
        array4 = new int[lenght4];
        for (int i = 0; i < lenght4; i++)
            array4[i] = (i + 1) * 3;
    }
}
