using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject player;

    // Stage Enum
    public enum Stage
    {
        Stage0,
        Stage1,
        Stage2,
        Stage3,
        Stage4,
        Stage5,
        Stage6,
        Stage7,
        Stage8
    }

    // Enum에서 랜덤 값을 가져오는 함수
    public Stage GetRandomStage()
    {
        // 모든 Enum 값을 배열로 가져오기
        Stage[] stages = (Stage[])System.Enum.GetValues(typeof(Stage));

        // 랜덤 인덱스 생성
        int randomIndex = Random.Range(0, stages.Length);

        // 랜덤 Stage 반환
        return stages[randomIndex];
    }

    public int level = 0;
    public Stage current_stage = Stage.Stage0;

    public void Reset()
    {
        level = 0;
        current_stage = Stage.Stage0;
    }

    public void NextStage()
    {
        if (level < 7)
        {
            level++;
            current_stage = GetRandomStage();
        }
        else
        {
            Debug.Log("Game Over");
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
