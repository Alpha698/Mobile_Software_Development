using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Lab6 : MonoBehaviour
{
    [Header ("Окна приложения")]
    public GameObject mainPanel;
    public GameObject settingsPanel;

    [Header("Обьекты главного окна")]
    public TextMeshProUGUI textNotification;
    public TextMeshProUGUI textAdress;
    public TextMeshProUGUI textAboutCheckBox2;
    public Button openSettings;

    [Header("Обьекты окна настроек")]
    public Toggle flagNotification;
    public GameObject adressPanel;
    public InputField enterAdress;
    public Toggle flagCheckBox2;
    public Button saveSettings;
    public Button clearSettings;

    private void Start()
    {
        openSettings.onClick.AddListener(OpenSettings);
        saveSettings.onClick.AddListener(SavePrefSettings);
        clearSettings.onClick.AddListener(ClearPrefSettings);
    }

    private void Update()
    {
        //считывание данных с плеерпреф
        textNotification.text = PlayerPrefs.GetString("Notification");
        textAdress.text = PlayerPrefs.GetString("Adress");
        textAboutCheckBox2.text = PlayerPrefs.GetString("CheckBox2");
        //скрывать поле ввода адреса если чек бокс не выставлен
        if (flagNotification.isOn)
        {
            adressPanel.SetActive(true);
        }
        else
        {
            adressPanel.SetActive(false);
        }
    }

    private void OpenSettings()
    {
        mainPanel.SetActive(false);
        settingsPanel.SetActive(true);
        //считывание данных с плеерпреф
        if (PlayerPrefs.GetString("Notification") == "True")
        {
            flagNotification.isOn = true;
        }
        else
        {
            flagNotification.isOn = false;
        }
        enterAdress.text = PlayerPrefs.GetString("Adress");
        if (PlayerPrefs.GetString("CheckBox2") == "True")
        {
            flagCheckBox2.isOn = true;
        }
        else
        {
            flagCheckBox2.isOn = false;
        }
    }
    private void SavePrefSettings()
    {
        //сохранение данных в кэш
        PlayerPrefs.SetString("Notification", flagNotification.isOn.ToString());
        PlayerPrefs.SetString("Adress", enterAdress.text);
        PlayerPrefs.SetString("CheckBox2", flagCheckBox2.isOn.ToString());
        //закрытие окна
        mainPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }
    private void ClearPrefSettings()
    {
        //удаление данных из кэша
        PlayerPrefs.DeleteAll();
        //закрытие окна
        mainPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }
}
