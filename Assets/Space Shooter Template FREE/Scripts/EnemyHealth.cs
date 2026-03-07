using UnityEngine;

public class EnemyHealth : Health
{
    // Biến dùng chung để đếm toàn bộ kẻ địch trong cảnh
    public static int LivingEnemyCount;

    private void Awake()
    {
        // Mỗi khi một Enemy sinh ra, tăng biến đếm lên 1
        LivingEnemyCount++;
    }

    protected override void Die()
    {
        // Trước khi nổ tung, giảm biến đếm đi 1
        LivingEnemyCount--;

        // Gọi hàm Die gốc của lớp Health để xử lý nổ và xóa đối tượng
        base.Die();
    }
}