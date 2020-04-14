using UnityEngine;
using UnityEngine.UI;
public class Lab3 : MonoBehaviour
{
    public Button myButton;
    public Text mytext;
    // Start is called before the first frame update
    void Start()
    {
        myButton.onClick.AddListener(ClickButton);
    }

    void ClickButton()
    {
        mytext.text = "PRESS BUTTON";
        Debug.Log("PRESS BUTTON");
    }
}

