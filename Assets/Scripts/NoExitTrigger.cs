using UnityEngine;
using System.Collections; // 코루틴 사용을 위한 네임스페이스
using UnityEngine.XR.Interaction.Toolkit;

public class NoExitTrigger : MonoBehaviour
{
    public Transform spawnPoint; // 스폰 지점 Transform
    public TeleportationProvider teleportationProvider;
    private void Start()
    {
        teleportationProvider = FindObjectOfType<TeleportationProvider>();
        if (teleportationProvider == null)
        {
            Debug.LogError("TeleportationProvider not found in the scene.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ExitTrigger OnTriggerEnter");
        // Tag가 "Player"인 오브젝트만 처리
        if (other.transform.root.CompareTag("Player"))
        {
            Debug.Log("ExitTrigger OnTriggerEnter Player");
            StartCoroutine(Respawn(other.transform.root.gameObject));
        }
    }

    private IEnumerator Respawn(GameObject player)
    {
        Debug.Log("ExitTrigger Respawn");
        Debug.Log(player.name);

        // 플레이어를 스폰 지점으로 이동
        TeleportRequest request = new TeleportRequest
            {
                destinationPosition = spawnPoint.position,
                destinationRotation = Quaternion.identity
            };

            // 순간이동 실행
            teleportationProvider.QueueTeleportRequest(request);
            Debug.Log("Teleporting player to: " + spawnPoint.position);

        // 현재 level과 current_stage 값을 저장
        int previousLevel = GameManager.Instance.level;
        GameManager.Stage previousStage = GameManager.Instance.current_stage;

        // GameManager의 current_stage에 따라 행동 결정
        if (GameManager.Instance.current_stage != GameManager.Stage.Stage0)
        {
            // Stage0이면 Reset 호출
            GameManager.Instance.Reset();
            Debug.Log("Stage is not Stage0. Reset called.");
        }
        else
        {
            // Stage0이 아니면 NextStage 호출
            GameManager.Instance.NextStage();
            Debug.Log($"NextStage called. Level: {GameManager.Instance.level}, Current Stage: {GameManager.Instance.current_stage}");
        }

        // 변경된 level과 current_stage 값을 저장
        int updatedLevel = GameManager.Instance.level;
        GameManager.Stage updatedStage = GameManager.Instance.current_stage;

        // 오브젝트 이름 생성 및 위치 변경
        string previousObjectName = $"digit{8 - previousLevel}";
        string updatedObjectName = $"digit{8 - updatedLevel}";

        // 이전 오브젝트와 변경된 오브젝트의 참조 가져오기
        GameObject previousObject = GameObject.Find(previousObjectName);
        GameObject updatedObject = GameObject.Find(updatedObjectName);

        if (previousObject != null && updatedObject != null)
        {
            // 두 오브젝트의 위치를 서로 바꾸기
            Vector3 tempPosition = previousObject.transform.position;
            previousObject.transform.position = updatedObject.transform.position;
            updatedObject.transform.position = tempPosition;

            Debug.Log($"Swapped positions of {previousObjectName} and {updatedObjectName}");
        }
        else
        {
            Debug.LogWarning($"One or both objects not found: {previousObjectName}, {updatedObjectName}");
        }
        // 코루틴 종료를 명시적으로 처리
        yield return null;
    }
}