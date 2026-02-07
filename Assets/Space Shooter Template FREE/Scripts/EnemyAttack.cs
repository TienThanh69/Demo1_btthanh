using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Tham chiếu đến chính script Health của quân địch này
    public EnemyHealth health;
    // Sát thương gây ra cho người chơi
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra xem vật chạm phải có script PlayerHealth không
        var playerHealth = collision.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            // 1. Gây sát thương cho người chơi
            playerHealth.TakeDamage(damage);

            // 2. Kẻ địch tự tiêu diệt (tấn công cảm tử)
            // Truyền vào 1 con số cực lớn để chắc chắn kẻ địch nổ ngay lập tức
            health.TakeDamage(9999);
        }
    }
}