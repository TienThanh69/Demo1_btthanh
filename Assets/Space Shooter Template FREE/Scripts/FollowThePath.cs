using UnityEngine;

public class FollowThePath : MonoBehaviour
{
    [Header("Movement Settings")]
    public Transform[] path;        // Để kiểu Transform[] để khớp với Wave.cs
    public FlyPath flyPathManual;   // Ô để bạn kéo FlyPath (Demo 7) vào thủ công

    public float speed = 2f;
    public bool rotationByPath = true;
    public bool loop = false;

    private int currentPointIndex = 0;

    void Start()
    {
        // Nếu bạn gán FlyPath thủ công trong Inspector (Demo 7)
        if (flyPathManual != null && (path == null || path.Length == 0))
        {
            path = new Transform[flyPathManual.waypoints.Length];
            for (int i = 0; i < flyPathManual.waypoints.Length; i++)
            {
                path[i] = flyPathManual.waypoints[i].transform;
            }
        }
    }

    void Update()
    {
        // Nếu không có điểm mốc nào thì máy bay sẽ không di chuyển
        if (path == null || path.Length == 0) return;

        Vector3 targetPos = path[currentPointIndex].position;

        // Di chuyển máy bay
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        // Xoay máy bay theo hướng bay
        if (rotationByPath)
        {
            Vector3 direction = targetPos - transform.position;
            if (direction != Vector3.zero)
            {
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            }
        }

        // Chuyển điểm mốc
        if (Vector2.Distance(transform.position, targetPos) < 0.1f)
        {
            currentPointIndex++;
            if (currentPointIndex >= path.Length)
            {
                if (loop) currentPointIndex = 0;
                else Destroy(gameObject);
            }
        }
    }

    // Hàm SetPath KHÔNG tham số để sửa lỗi cho Wave.cs
    public void SetPath()
    {
        currentPointIndex = 0;
    }

    // Hàm SetPath CÓ tham số (nếu cần dùng sau này)
    public void SetPath(FlyPath newPath)
    {
        flyPathManual = newPath;
        currentPointIndex = 0;
    }
}