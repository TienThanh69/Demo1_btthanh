using UnityEngine;

public class FlyPathAgent : MonoBehaviour
{
    public FlyPath flyPath;
    public float flySpeed = 5f;
    private int nextIndex = 1;

    void Start()
    {
        // Khi mới sinh ra, máy bay sẽ tự động hướng về điểm mốc số 1
        nextIndex = 1;
    }

    void Update()
    {
        if (flyPath == null || flyPath.waypoints.Length == 0) return;

        // Nếu đã đi hết các điểm mốc, thì biến mất (Trang 16)
        if (nextIndex >= flyPath.waypoints.Length)
        {
            Destroy(gameObject);
            return;
        }

        // 1. Di chuyển tới điểm mốc tiếp theo
        Vector3 targetPos = flyPath[nextIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetPos, flySpeed * Time.deltaTime);

        // 2. Xoay đầu máy bay (Trang 9)
        LookAt(targetPos);

        // 3. Kiểm tra nếu đã đến sát điểm mốc (dùng Distance thay vì ==)
        if (Vector3.Distance(transform.position, targetPos) < 0.1f)
        {
            nextIndex++;
        }
    }

    private void LookAt(Vector2 destination)
    {
        Vector2 position = transform.position;
        var lookDirection = destination - position;
        if (lookDirection.magnitude < 0.01f) return;

        var angle = Vector2.SignedAngle(Vector3.down, lookDirection);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}