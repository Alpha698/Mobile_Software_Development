using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
public class ModuleKate : MonoBehaviour
{
    [Header("Окна приложения")]
    public GameObject inputPanel;
    public GameObject outputPanel;
    public Button toActivity;

    [Header("Обьекты окна ввода")]
    public InputField enterA;
    public InputField enterB;
    public Button startBttn;
    public GameObject popupInfo;

    [Header("Обьекты окна вывода")]
    public GameObject panelResult;
    public TextMeshProUGUI textResult;

    private void Start()
    {
        //слушатели на кнопки
        toActivity.onClick.AddListener(OpenView);
        startBttn.onClick.AddListener(StartC);
    }
    void StartC()
    {
        //открывает попап с таймером
        StartCoroutine(ShowInfo());
    }
    IEnumerator ShowInfo()
    {
        popupInfo.SetActive(true);
        yield return new WaitForSeconds(4f);
        popupInfo.SetActive(false);
    }
    //метод открытия/закрытия окон
    private void OpenView()
    {
        //тернарные выражение вместо if на 10 строк
        outputPanel.SetActive(!outputPanel.activeSelf ? true : false);
        inputPanel.SetActive(!inputPanel.activeSelf ? true : false);
        //считаем функцию
        if (outputPanel.activeSelf)
            Calculate(int.Parse(enterA.text), int.Parse(enterB.text));
    }
    //метод подсчета
    private void Calculate(int a, int b)
    {
        //создание поля для текста в рантайме и запись в него значений
        TextMeshProUGUI tempText = Instantiate(textResult);
        tempText.text = "a = "+a+" b = "+b;
        tempText.transform.SetParent(panelResult.transform,false);
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
