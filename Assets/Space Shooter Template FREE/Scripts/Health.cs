using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Settings")]
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 3;

    private int healthPoint;

    private void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    public void TakeDamage(int damage)
    {
        // Kiểm tra nếu máu đã hết thì không làm gì cả
        if (healthPoint <= 0) return;

        healthPoint -= damage;

        // Nếu máu sau khi trừ mà bằng hoặc nhỏ hơn 0 thì tử trận
        if (healthPoint <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }
        Destroy(gameObject);
    }
}