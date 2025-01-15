using UnityEngine;

public class Stage1 : MonoBehaviour
{
    public GameObject character;
    //public GameObject Dragon = null;
    public Color targetColor = Color.white;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        character.SetActive(true);
        //if (Dragon != null)
        //{
        //    Dragon.SetActive(true);
        //}
        RenderSettings.ambientLight = targetColor;
    }
}
