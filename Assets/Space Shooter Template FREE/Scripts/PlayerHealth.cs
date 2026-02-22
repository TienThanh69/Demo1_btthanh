using UnityEngine;

public class PlayerHealth : Health
{
    // Kéo CanvasGameOver vào ô này trong Inspector
    public GameObject gameOverCanvas;

    protected override void Die()
    {
        base.Die();
        // Hiện bảng Game Over lên
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(true);
        }
    }
}