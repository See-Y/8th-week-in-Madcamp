using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject player;
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;

    // Stage Enum
    public enum Stage
    {
        Stage0,
        Stage1,
        Stage2,
        Stage3,
        // Stage4,
        // Stage5,
        // Stage6,
        // Stage7,
        // Stage8
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
        if (level < 3)
        {
            level++;
            current_stage = (Stage)(level);
            if (current_stage == Stage.Stage1)
            {
                stage1.SetActive(true);
            }
            else if (current_stage == Stage.Stage2)
            {
                stage2.SetActive(true);
            }
            else if (current_stage == Stage.Stage3)
            {
                stage3.SetActive(true);
            }
        }
        else
        {
            Debug.Log("Game Clear");
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instance = this;
    }

}
