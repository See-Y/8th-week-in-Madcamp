using UnityEngine;

public class Stage3 : MonoBehaviour
{
    public GameObject Goose;
    public GameObject Nubjuk = null;
    public Color targetColor = Color.white;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Goose.SetActive(true);
        Nubjuk.SetActive(false);
        RenderSettings.ambientLight = targetColor;
    }
}
