using UnityEngine;
using System; // Bắt buộc phải có dòng này để dùng Action

public class Health : MonoBehaviour
{
    [Header("Settings")]
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 3;

    // Sự kiện thông báo khi đối tượng bị tiêu diệt
    public Action onDead;

    private int healthPoint;

    private void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;

        if (healthPoint <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        // Tạo hiệu ứng nổ
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }

        // Xóa đối tượng khỏi màn hình
        Destroy(gameObject);

        // Phát tín hiệu "đã chết" cho các hệ thống khác (như BattleFlow)
        onDead?.Invoke();
    }
}