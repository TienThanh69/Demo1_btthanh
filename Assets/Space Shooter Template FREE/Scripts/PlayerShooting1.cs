using UnityEngine;

public class PlayerShooting1 : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval = 0.1f;

    // Tạo 2 ô để kéo 2 điểm nòng súng vào từ Inspector
    public Transform gunPointLeft;
    public Transform gunPointRight;

    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
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
            // Bắn đạn tại vị trí nòng trái
            Instantiate(bulletPrefabs, gunPointLeft.position, gunPointLeft.rotation);
            // Bắn đạn tại vị trí nòng phải
            Instantiate(bulletPrefabs, gunPointRight.position, gunPointRight.rotation);
        }
    }
}