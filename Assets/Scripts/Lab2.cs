using UnityEngine;
using UnityEngine.UI;


public class Lab2 : MonoBehaviour
{
    public GameObject VerticalGroup;
    public GameObject HorizontalGroup;
    public Text Title;

    // Update is called once per frame
    void Update()
    {
        if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            Debug.Log("Landscape");
            Title.text = "Горизонтальная ориентация экрана";
            VerticalGroup.SetActive(false);
            HorizontalGroup.SetActive(true);
        }
        else if (Screen.orientation == ScreenOrientation.Portrait)
        {
            Debug.Log("Portrait");
            Title.text = "Вертикальная ориентация экрана";
            VerticalGroup.SetActive(true);
            HorizontalGroup.SetActive(false);
        }
    }
}
