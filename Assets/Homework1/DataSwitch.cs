using UnityEngine;

public class DataSwitch : MonoBehaviour
{
    [SerializeField] string string1;
    [SerializeField] string string2;
    void Start()
    {
        string temp1 = string1;
        string1 = string2;
        string2 = temp1;
    }
}
