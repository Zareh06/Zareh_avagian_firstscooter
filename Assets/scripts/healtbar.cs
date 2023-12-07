using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBarFill;
    public float maxHealth = 100f;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        float fillAmount = currentHealth / maxHealth;
        healthBarFill.fillAmount = fillAmount;
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
        UpdateHealthBar();
    }

    public void Heal(float healAmount)
    {
        currentHealth += healAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth);
        UpdateHealthBar();
    }
}
