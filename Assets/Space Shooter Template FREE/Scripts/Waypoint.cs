using UnityEngine;

public class Waypoint : MonoBehaviour
{
    // Vẽ điểm mốc trong cửa sổ Scene
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, 0.1f);
    }
}