using UnityEngine;
using TMPro;
using System.Collections;

public class Damageable : MonoBehaviour
{
    [SerializeField] float startHealth = 100;

    [SerializeField] Gradient healthGradient;
    [SerializeField] TMP_Text textComponent;
    [SerializeField] Behaviour disableOnDeath;
    [SerializeField] GameObject enableOnDeath;

    [Space]
    [SerializeField] float invincibilityTime;
    [SerializeField] float flickTime = 0.1f;
    [SerializeField] new Collider collider;

    float currentHealth;

    private void Start()
    {
        currentHealth = startHealth;
        UpdateHealthUI();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            currentHealth = startHealth;
            UpdateHealthUI();
        }
    }

    public void Damage(float damage)
    {
        currentHealth -= damage;

        collider.enabled = false;
        StartCoroutine(HandleInvincible());

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

    IEnumerator HandleInvincible()
    {
        collider.enabled = false;
        float startTime = Time.time;
        bool rendererEnabled = true;
        while (Time.time - startTime < invincibilityTime)
        {
            rendererEnabled = !rendererEnabled;
            SetRendererEnabled(rendererEnabled);

            yield return new WaitForSeconds(flickTime);
        }
        SetRendererEnabled(true);
        collider.enabled = true;
    }

    void SetRendererEnabled(bool enabled)
    {
        foreach (Renderer renderer in GetComponentsInChildren<Renderer>())
            renderer.enabled = enabled;
    }
}
