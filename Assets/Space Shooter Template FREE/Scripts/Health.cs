using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 3;

    public Action onDead;
    public Action onHealthChanged;

    public int healthPoint;

    protected virtual void Start()
    {
        healthPoint = defaultHealthPoint;
        if (onHealthChanged != null) onHealthChanged.Invoke();
    }

    public virtual void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;

        if (onHealthChanged != null) onHealthChanged.Invoke();

        if (healthPoint <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }

        Destroy(gameObject);

        if (onDead != null) onDead.Invoke();
    }
}