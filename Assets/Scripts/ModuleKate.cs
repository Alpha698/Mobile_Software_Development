using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModuleKate : MonoBehaviour
{
    [Header ("Окна приложения")]
    public GameObject inputPanel;
    public GameObject outputPanel;

    [Header("Обьекты окна ввода")]
    public InputField enterX;
    public Button calculate;

    [Header("Обьекты окна вывода")]
    public TextMeshProUGUI textResult;
    public Button backPanel;



    private void Start()
    {
        calculate.onClick.AddListener(CalculateData);
        backPanel.onClick.AddListener(OpenView);
    }

    private void CalculateData()
    {
        int x = int.Parse(enterX.text);
    }

    private void OpenView()
    {
        inputPanel.SetActive(true);
        outputPanel.SetActive(false);
    }

    private void Update()
    {
        //int x = int.Parse(enterX.text);
        ////= PlayerPrefs.GetInt("Notification");
        //textAdress.text = PlayerPrefs.GetString("Adress");
        //textAboutCheckBox2.text = PlayerPrefs.GetString("CheckBox2");
        ////скрывать поле ввода адреса если чек бокс не выставлен
        //if (flagNotification.isOn)
        //{
        //    adressPanel.SetActive(true);
        //}
        //else
        //{
        //    adressPanel.SetActive(false);
        //}
    }

    //private void OpenSettings()
    //{
    //    mainPanel.SetActive(false);
    //    settingsPanel.SetActive(true);
    //    //считывание данных с плеерпреф
    //    if (PlayerPrefs.GetString("Notification") == "True")
    //    {
    //        flagNotification.isOn = true;
    //    }
    //    else
    //    {
    //        flagNotification.isOn = false;
    //    }
    //    enterAdress.text = PlayerPrefs.GetString("Adress");
    //    if (PlayerPrefs.GetString("CheckBox2") == "True")
    //    {
    //        flagCheckBox2.isOn = true;
    //    }
    //    else
    //    {
    //        flagCheckBox2.isOn = false;
    //    }
    //}
    //private void SavePrefSettings()
    //{
    //    //сохранение данных в кэш
    //    PlayerPrefs.SetString("Notification", flagNotification.isOn.ToString());
    //    PlayerPrefs.SetString("Adress", enterAdress.text);
    //    PlayerPrefs.SetString("CheckBox2", flagCheckBox2.isOn.ToString());
    //    //закрытие окна
    //    mainPanel.SetActive(true);
    //    settingsPanel.SetActive(false);
    //}
    //private void ClearPrefSettings()
    //{
    //    //удаление данных из кэша
    //    PlayerPrefs.DeleteAll();
    //    //закрытие окна
    //    mainPanel.SetActive(true);
    //    settingsPanel.SetActive(false);
    //}
}
