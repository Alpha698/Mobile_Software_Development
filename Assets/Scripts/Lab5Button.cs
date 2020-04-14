using UnityEngine;
using UnityEngine.UI;


public class Lab5Button : MonoBehaviour
{
    public Button thisButton;

    private void Start()
    {
        thisButton.onClick.AddListener(DestroyObj);
    }

    public void DestroyObj()
    {
        Debug.Log("DESTROY");
        // Удаление себя
        Destroy(gameObject);
    }

}
