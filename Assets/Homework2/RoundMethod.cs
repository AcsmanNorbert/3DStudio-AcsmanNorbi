using UnityEngine;

public class RoundMethod : MonoBehaviour
{
    [SerializeField] float change;

    void Start()
    {
        Debug.Log(FloorFloat(change));
        Debug.Log(CeilingFloat(change));
        Debug.Log(RoundFloat(change));
    }

    float FloorFloat(float number)
    {
        return (int)number;
    }

    float CeilingFloat(float number)
    {
        if (number >= 0f)
        {
            if ((number - (int)number) > 0f)
                number = (int)number + 1;
        }
        else
            number = (int)number;
        return number;
    }

    float RoundFloat(float number)
    {
        if (number >= 0f)
            if ((number - (int)number) >= 0.5f)
                number = (int)number + 1;
            else
                number = (int)number;
        else
            number = (int)number;
        return number;
    }
}
