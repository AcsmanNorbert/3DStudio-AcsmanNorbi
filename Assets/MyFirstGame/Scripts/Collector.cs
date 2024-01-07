using TMPro;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    int coins;

    private void Start()
    {
        UpdateUI();
    }

    void OnTriggerEnter(Collider other)
    {
        Collectable collectable = other.GetComponent<Collectable>();
        if (collectable != null)
        {
            coins += collectable.GetAmount();
            //GameObject.Destroy(collectable.gameObject);
            collectable.OnCollect();
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        text.text = coins.ToString();
    }
}
