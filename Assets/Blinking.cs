using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Lấy thành phần SpriteRenderer từ đối tượng
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Đảo ngược trạng thái hiển thị (Bật -> Tắt, Tắt -> Bật)
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }
}