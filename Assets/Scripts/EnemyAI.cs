using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
using System.Collections;
using UnityEngine.XR;
public enum EnemyState
{
    Walking,
    Running,
    Searching,
    Screaming,
    Caught
}

public class EnemyAI : MonoBehaviour
{
    public EnemyState currentState = EnemyState.Walking;

    public Transform player; // 플레이어 위치
    public float detectRange = 10f; // 플레이어를 발견하는 범위
    public float loseRange = 15f; // 플레이어를 놓치는 범위
    public Transform[] patrolPoints; // 배회 루트
    public float screamInterval = 20f; // 소리지르는 간격
    public Transform enemyFace; // 적의 얼굴 위치
    private NavMeshAgent agent;
    private Animator animator;
    private int currentPatrolIndex = 0;
    private float screamTimer;

    public AudioSource audioSource; // AudioSource 참조
    public AudioSource audioSource2; // AudioSource 참조
    public AudioClip soundEffect;   // 재생할 AudioClip
    public AudioClip bgm;   // 재생할 AudioClip
    public AudioSource audioSource3;
    public AudioClip screem;
    private bool isDeathSceneTriggered = false; // 죽음 씬 트리거 상태
    private Camera xrCamera;
    private Transform xrRig; // XR Rig의 transform
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoRepath = true;

        animator = GetComponent<Animator>();
        screamTimer = screamInterval;
        audioSource.PlayOneShot(bgm); // 효과음 재생
        GoToNextPatrolPoint();



        xrCamera = Camera.main;
        // XR Rig를 찾습니다 (보통 XR Origin이라는 이름을 가진 게임오브젝트입니다)
        xrRig = xrCamera.transform.parent;
        
        // XR 트래킹을 비활성화
        XRDevice.DisableAutoXRCameraTracking(xrCamera, true);
    }

    private void Update()
    {
        if (isDeathSceneTriggered) return; // 죽음 씬 중에는 Update 중단
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        switch (currentState)
        {
            case EnemyState.Walking:
                HandleWalkingState(distanceToPlayer);
                break;
            case EnemyState.Running:
                HandleRunningState(distanceToPlayer);
                break;
            case EnemyState.Searching:
                HandleSearchingState();
                break;
            case EnemyState.Screaming:
                HandleScreamingState();
                break;
            case EnemyState.Caught:
                HandleCaughtState();
                break;
        }
        
    }

    private void HandleWalkingState(float distanceToPlayer)
    {
        animator.SetBool("Walking", true);

        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GoToNextPatrolPoint();
        }

        screamTimer -= Time.deltaTime;
        if (screamTimer <= 0f)
        {
            currentState = EnemyState.Screaming;
            screamTimer = screamInterval;
            return;
        }

        if (distanceToPlayer <= detectRange)
        {
            currentState = EnemyState.Running;
            audioSource2.PlayOneShot(soundEffect); // 효과음 재생
        }
    }

    private void HandleRunningState(float distanceToPlayer)
    {
        animator.SetBool("Walking", false);
        animator.SetBool("Running", true);

        agent.SetDestination(player.position);

        if (distanceToPlayer > loseRange)
        {
            currentState = EnemyState.Searching;
            audioSource2.Stop(); // 효과음 멈춤
        }
    }

    private void HandleSearchingState()
    {
        animator.SetBool("Running", false);
        animator.SetBool("Searching", true);

        // 애니메이션이 끝난 후 Walking 상태로 전환
        Invoke("SwitchToWalkingState", 2f);
    }

    private void HandleScreamingState()
    {
        audioSource3.PlayOneShot(screem);
        animator.SetTrigger("Screaming");

        // 애니메이션이 끝난 후 Walking 상태로 전환
        Invoke("SwitchToWalkingState", 2f);
    }

    private void HandleCaughtState()
    {
        animator.SetTrigger("Caught");
        agent.isStopped = true;
        // 더 이상 행동하지 않음
    }

    private void SwitchToWalkingState()
    {
        animator.SetBool("Searching", false);
        currentState = EnemyState.Walking;
        GoToNextPatrolPoint();
    }

    private void GoToNextPatrolPoint()
    {
        if (patrolPoints.Length == 0)
            return;

        agent.destination = patrolPoints[currentPatrolIndex].position;
        currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))
        {
            TriggerDeathScene();
            Debug.Log("Trigger!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            StartCoroutine(ReloadSceneAfterDelay(5.0f));
        }
    }

    private IEnumerator ReloadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    IEnumerator SmoothCameraTransition(Transform target)
    {
        float duration = 1.5f; // 전환 시간
        Vector3 startPosition = Camera.main.transform.position;
        Quaternion startRotation = Camera.main.transform.rotation;

        for (float t = 0; t < duration; t += Time.deltaTime)
        {
            Camera.main.transform.position = Vector3.Lerp(startPosition, target.position, t / duration);
            Camera.main.transform.rotation = Quaternion.Slerp(startRotation, target.rotation, t / duration);
            yield return null;
        }

        Camera.main.transform.position = target.position;
        Camera.main.transform.rotation = target.rotation;

        XRDevice.DisableAutoXRCameraTracking(Camera.main, true);
    }
void TriggerDeathScene()
{
    if (isDeathSceneTriggered) return; // 죽음 씬 중복 실행 방지
    isDeathSceneTriggered = true;

    currentState = EnemyState.Caught; // 상태를 Caught로 변경
    agent.isStopped = true; // 이동 멈춤
    animator.SetTrigger("Caught"); // Caught 애니메이션 실행

    // 플레이어 움직임 비활성화
    Cameracontroller playerMovement = player.GetComponent<Cameracontroller>();
    if (playerMovement != null)
    {
        playerMovement.DisableMovement();
    }

    StartCoroutine(SmoothCameraTransition(enemyFace)); // 카메라 전환
}
    void LateUpdate()
    {
        if (isDeathSceneTriggered && xrRig != null)
        {
            // XR Rig의 위치를 조정하여 카메라가 EnemyFace 위치에 오도록 합니다
            Vector3 offset = xrCamera.transform.localPosition;
            xrRig.position = enemyFace.position - offset;
            xrRig.rotation = enemyFace.rotation;
        }
    }

}
