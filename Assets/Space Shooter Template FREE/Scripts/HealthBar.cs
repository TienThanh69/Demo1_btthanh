using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBarFill;
    public Health health;

    void Start()
    {
        if (health != null)
        {
            health.onHealthChanged += UpdateHealthBar;
        }
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        if (health != null && healthBarFill != null)
        {
            healthBarFill.fillAmount = (float)health.healthPoint / health.defaultHealthPoint;
        }
    }
}