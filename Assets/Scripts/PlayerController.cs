using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // 입력 받기
        float moveX = Input.GetAxis("Horizontal"); // A/D 또는 좌/우 화살표
        float moveZ = Input.GetAxis("Vertical");   // W/S 또는 위/아래 화살표

        // 이동 계산
        Vector3 move = new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;

        // 실제 이동
        transform.Translate(move, Space.World);
    }
}
