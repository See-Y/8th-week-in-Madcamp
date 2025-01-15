using UnityEngine;

public class Stage2 : MonoBehaviour
{
    public GameObject Nubjuk;
    public Color targetColor = Color.white;
    public GameObject character;
    // public Color targetColor = Color.white;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Nubjuk.SetActive(true);
        character.SetActive(false);
        RenderSettings.ambientLight = targetColor;
    }
}
