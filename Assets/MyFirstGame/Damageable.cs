using UnityEngine;
using TMPro;

public class Damageable : MonoBehaviour
{
    [SerializeField] float startHealth = 100;
    [SerializeField] TMP_Text textComponent;
    float currentHealth;

    private void Start()
    {
        currentHealth = startHealth;
        UpdateHealthUI();
    }

    public void Damage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
            currentHealth = 0;

        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        textComponent.text = currentHealth.ToString();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
            currentHealth = startHealth;
    }
}
