using UnityEngine;
using UnityEngine.SceneManagement; // Thư viện để chuyển cảnh

public class MainMenu : MonoBehaviour
{
    // Hàm này sẽ chạy khi bạn nhấn nút Play
    public void OnPlayButtonClicked()
    {
        // Load cảnh có số thứ tự là 1 trong Build Settings (Cảnh Battle)
        SceneManager.LoadScene(1);
    }

    // Thêm hàm này vào trong class MainMenu ở Bước 1
    public void OnReturnToMainMenu()
    {
        SceneManager.LoadScene(0); // Quay về cảnh Menu (số 0)
    }
}