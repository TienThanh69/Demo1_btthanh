using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public Renderer bgRenderer; // Kéo chính nó vào đây
    public float speed = 0.1f;  // Tốc độ trượt

    void Update()
    {
        // Thay đổi thông số Offset của Texture theo thời gian
        Vector2 offset = new Vector2(0, Time.time * speed);
        bgRenderer.material.mainTextureOffset = offset;
    }
}