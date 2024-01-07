using UnityEngine;
using UnityEngine.Serialization;

class ColorSwitch : MonoBehaviour
{
    [SerializeField, FormerlySerializedAs("light")] Light spotlight;
    [SerializeField] Gradient colors;
    [SerializeField] float speed;

    private void Update()
    {
        float scaledTime = Time.time * speed;
        float t = scaledTime % 1;
        if ((int)scaledTime % 2 == 1)
            t = 1 - t;
        spotlight.color = colors.Evaluate(t);
    }
}
