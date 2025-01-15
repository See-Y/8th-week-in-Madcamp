using UnityEngine;
using UnityEngine.AI;
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

    private NavMeshAgent agent;
    private Animator animator;
    private int currentPatrolIndex = 0;
    private float screamTimer;

    public AudioSource audioSource; // AudioSource 참조
    public AudioSource audioSource2; // AudioSource 참조
    public AudioClip soundEffect;   // 재생할 AudioClip
    public AudioClip bgm;   // 재생할 AudioClip

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoRepath = true;

        animator = GetComponent<Animator>();
        screamTimer = screamInterval;
        audioSource.PlayOneShot(bgm); // 효과음 재생
        GoToNextPatrolPoint();
    }

    private void Update()
    {
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentState = EnemyState.Caught;
        }
    }
}
