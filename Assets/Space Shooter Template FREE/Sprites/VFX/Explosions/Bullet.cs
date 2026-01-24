using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Biến để điều chỉnh tốc độ bay của đạn từ cửa sổ Inspector
    public float flySpeed;

    void Update()
    {
        // 1. Lấy vị trí hiện tại của viên đạn
        var newPosition = transform.position;

        // 2. Tính toán vị trí mới trên trục Y (bay lên trên)
        // Time.deltaTime giúp đạn bay mượt mà, không phụ thuộc vào tốc độ máy tính
        newPosition.y += Time.deltaTime * flySpeed;

        // 3. Cập nhật vị trí mới cho viên đạn
        transform.position = newPosition;
    }
}