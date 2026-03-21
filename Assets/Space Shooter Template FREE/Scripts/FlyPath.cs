using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Waypoint[] waypoints;

    // 1. Vẽ đường nối giữa các điểm trong Scene (Trang 4)
    private void OnDrawGizmos()
    {
        if (waypoints == null || waypoints.Length < 2) return;

        Gizmos.color = Color.green;
        for (int i = 0; i < waypoints.Length - 1; i++)
        {
            if (waypoints[i] != null && waypoints[i + 1] != null)
            {
                Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i + 1].transform.position);
            }
        }
    }

    // 2. Thêm Indexer để truy cập vị trí nhanh hơn (Trang 5)
    // Giúp dùng flyPath[i] thay vì flyPath.waypoints[i].transform.position
    public Vector3 this[int index] => waypoints[index].transform.position;
}