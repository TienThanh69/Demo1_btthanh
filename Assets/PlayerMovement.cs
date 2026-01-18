using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        // Dòng này sẽ in tọa độ chuột liên tục ra Console để bạn kiểm tra
        Debug.Log("Toạ độ chuột: " + mousePos);

        mousePos.z = 10f;
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(mousePos);
        worldPoint.z = 0;
        transform.position = worldPoint;
    }
}