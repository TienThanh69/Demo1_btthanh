using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Waypoint[] waypoints;

    private void Reset()
    {
        // Tự động gom các Waypoint con vào mảng
        waypoints = GetComponentsInChildren<Waypoint>();
    }
}