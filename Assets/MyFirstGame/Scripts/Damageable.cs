using UnityEngine;
using TMPro;

public class Damageable : MonoBehaviour
{
    [SerializeField] float startHealth = 100;

    [SerializeField] Gradient healthGradient;
    [SerializeField] TMP_Text textComponent;
    [SerializeField] Behaviour disableOnDeath;
    [SerializeField] GameObject enableOnDeath;

    float currentHealth;

    private void Start()
    {
        currentHealth = startHealth;
        UpdateHealthUI();
    }

    public void Damage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;

            if(disableOnDeath != null)
                disableOnDeath.enabled = false;

            if (enableOnDeath != null)
                enableOnDeath.SetActive(true);
        }

        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        textComponent.text = Mathf.RoundToInt(currentHealth).ToString();

        float rate = currentHealth / startHealth;
        textComponent.color = healthGradient.Evaluate(rate);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            currentHealth = startHealth;
            UpdateHealthUI();
        }
    }
}
