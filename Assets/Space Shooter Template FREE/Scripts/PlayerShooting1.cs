using UnityEngine;

public class PlayerShooting1 : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval = 0.1f;

    // Biến để chỉnh vị trí đạn bay ra từ Inspector
    public Vector3 bulletOffset;

    private float lastBulletTime;

    void Update()
    {
        // Kiểm tra nếu người dùng đang giữ chuột trái (nút số 0)
        if (Input.GetMouseButton(0))
        {
            // Kiểm tra nhịp bắn tự động
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        if (bulletPrefabs != null)
        {
            // Cộng thêm bulletOffset vào vị trí hiện tại của máy bay
            Instantiate(bulletPrefabs, transform.position + bulletOffset, transform.rotation);
        }
    }
}