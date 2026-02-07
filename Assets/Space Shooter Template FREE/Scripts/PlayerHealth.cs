using UnityEngine;

// Kế thừa từ lớp Health để dùng chung hệ thống máu và vụ nổ
public class PlayerHealth : Health
{
    protected override void Die()
    {
        // Gọi lại hàm Die của lớp cha để tạo vụ nổ và biến mất
        base.Die();

        Debug.Log("Player died - Game Over!");
        // Sau này bạn có thể thêm logic hiện chữ "Game Over" ở đây
    }
}