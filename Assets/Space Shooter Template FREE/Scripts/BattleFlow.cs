using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    [Header("UI & Audio Settings")]
    public GameObject gameOverUI;
    public GameObject gameWinUI;
    public GameObject bgMusic;

    [Header("Reference")]
    public PlayerHealth playerHealth;

    private void Start()
    {
        if (gameOverUI != null) gameOverUI.SetActive(false);
        if (gameWinUI != null) gameWinUI.SetActive(false);

        if (playerHealth != null)
        {
            playerHealth.onDead += OnGameOver;
        }
    }

    private void Update()
    {
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }

    private void OnGameWin()
    {
        if (gameWinUI != null) gameWinUI.SetActive(true);
        if (bgMusic != null) bgMusic.SetActive(false);
        if (playerHealth != null) playerHealth.gameObject.SetActive(false);
    }

    private void OnGameOver()
    {
        if (gameOverUI != null) gameOverUI.SetActive(true);
        if (bgMusic != null) bgMusic.SetActive(false);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}