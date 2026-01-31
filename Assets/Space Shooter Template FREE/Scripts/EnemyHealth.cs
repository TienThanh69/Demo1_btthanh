using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Dòng này sẽ tạo ra ô trống trong Inspector để bạn kéo Prefab vào
    public GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    private void Die()
    {
        if (explosionPrefab != null)
        {
            // Tạo vụ nổ
            GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            // Xóa vụ nổ sau 1 giây
            Destroy(explosion, 1f);
        }
        // Xóa kẻ địch
        Destroy(gameObject);
    }
}