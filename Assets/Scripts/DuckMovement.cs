using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;  // 플레이어 Transform
    public float continueTime = 0.2f;  // 시야에서 벗어난 후 계속 움직이는 시간

    private Animator animator;
    private NavMeshAgent agent;
    private bool isMoving = false;
    private float moveTimer = 0f;
    private Camera mainCamera;
    private Quaternion lastRotation;  // 마지막 회전 값 저장

    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        mainCamera = Camera.main;  // 메인 카메라 참조
        lastRotation = transform.rotation;  // 초기 회전 값 저장
    }

    void Update()
    {
        if (!IsInCameraView())
        {
            isMoving = true;
            moveTimer = continueTime;  // 0.2초 타이머 초기화
            ResumeAnimation();  // 애니메이션 재개
        }

        if (isMoving)
        {
            MoveTowardPlayer();

            // 타이머 감소
            moveTimer -= Time.deltaTime;
            if (moveTimer <= 0)
            {
                isMoving = false;
                StopMoving();
            }
        }
        else
        {
            StopMoving();
        }
    }

    private bool IsInCameraView()
    {
        // 적의 월드 좌표를 카메라의 Viewport 좌표로 변환
        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(transform.position);

        // Viewport 좌표가 화면 내에 있는지 확인
        bool isInView = viewportPosition.z > 0 && // 카메라 앞에 위치
                        viewportPosition.x > 0 && viewportPosition.x < 1 && // 좌우 범위
                        viewportPosition.y > 0 && viewportPosition.y < 1;  // 상하 범위

        if (isInView)
        {
            PauseAnimation();  // 애니메이션 멈춤
        }

        return isInView;
    }

    private void MoveTowardPlayer()
    {
        // 적을 Y축으로 180도 뒤집어서 이동
        Vector3 directionToPlayer = (player.position - transform.position).normalized;
        directionToPlayer = new Vector3(directionToPlayer.x, 0, directionToPlayer.z);
        Quaternion flippedRotation = Quaternion.LookRotation(directionToPlayer) * Quaternion.Euler(0, 180, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, flippedRotation, Time.deltaTime * 5f);

        // 현재 회전 값 저장
        lastRotation = transform.rotation;

        // 애니메이션 변경
        animator.SetBool("isChasing", true);

        // NavMeshAgent로 플레이어를 추적
        agent.isStopped = false;
        agent.SetDestination(player.position);
    }

    private void StopMoving()
    {
        // 현재 회전 값 유지
        transform.rotation = lastRotation;

        // 애니메이션 변경
        animator.SetBool("isChasing", false);

        // NavMeshAgent 정지
        agent.isStopped = true;
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
    }

    private void PauseAnimation()
    {
        animator.speed = 0;  // 현재 실행 중인 애니메이션을 멈춤
        agent.isStopped = true;  // 이동도 멈춤
    }

    private void ResumeAnimation()
    {
        animator.speed = 1;  // 애니메이션 다시 재생
        agent.isStopped = false;  // 이동 재개
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 플레이어와 충돌 확인
        {
            Debug.Log("플레이어 잡힘!"); // 충돌 테스트
            TriggerDeathScene(); // 죽음 씬 실행
        }
    }

    void TriggerDeathScene()
    {
        Debug.Log("죽음 씬 시작!");
    }
}
