using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System;
public class Module : MonoBehaviour
{
    [Header("Окна приложения")]
    public GameObject inputPanel;
    public GameObject outputPanel;
    public Button bttnSwitchActivity;

    [Header("Обьекты окна ввода")]
    public InputField enterA;
    public InputField enterB;
    public InputField enterdX;
    public InputField entert;
    public GameObject popupInfo;

    [Header("Обьекты окна вывода")]
    public GameObject panelResult;
    public TextMeshProUGUI textResult;
    public Button calculateBttn;

    private void Start()
    {
        //слушатели на кнопки
        bttnSwitchActivity.onClick.AddListener(SwitchActivity);
        calculateBttn.onClick.AddListener(PreCalculate);
        StartCoroutine(ShowPopup());
    }

    IEnumerator ShowPopup()
    {
        popupInfo.SetActive(true);
        yield return new WaitForSeconds(3f);
        popupInfo.SetActive(false);
    }
    //метод открытия/закрытия окон
    private void SwitchActivity()
    {
        //тернарные выражение вместо if на 10 строк
        outputPanel.SetActive(!outputPanel.activeSelf ? true : false);
        inputPanel.SetActive(!inputPanel.activeSelf ? true : false);
    }

    private void PreCalculate()
    {
        Calculate(float.Parse(enterA.text), float.Parse(enterB.text), float.Parse(enterdX.text), float.Parse(entert.text));
    }

    //метод подсчета Катя
    //private void Calculate(float a, float b, float dx, float t)
    //{
    //    //обновление списка
    //    foreach (Transform child in panelResult.transform)
    //    {
    //        GameObject.Destroy(child.gameObject);
    //    }
    //    for (float i = a; i <= b; i = i + dx)
    //    {
    //        double y = 0;
    //        if (i < t)
    //        {
    //            y = Math.Pow(a * t, 2) - Math.Log(a * i);
    //        }
    //        if (i >= t)
    //        {
    //            y = Math.Pow(Math.E, a) - Math.Pow(i, a);
    //        }
    //        TextMeshProUGUI tempText = Instantiate(textResult);
    //        tempText.text = "x = " + i + " y = " + y.ToString();
    //        tempText.transform.SetParent(panelResult.transform, false);
    //    }
    //}

    //метод подсчета Леша
    //private void Calculate(float a, float b, float dx)
    //{
    //    //обновление списка
    //    foreach (Transform child in panelResult.transform)
    //    {
    //        GameObject.Destroy(child.gameObject);
    //    }
    //    //расчет функции
    //    for (float i = a; i <= b; i = i + dx)
    //    {
    //        double y = 0;
    //        float temp = 0.5f;
    //        if (i < temp)
    //        {
    //            y = Math.Sqrt(i);       
    //        }
    //        if (i >= temp)
    //        {
    //            y = Math.Exp(i);
    //        }
    //        TextMeshProUGUI tempText = Instantiate(textResult);
    //        tempText.text = "x = " + i + " y = " + y.ToString();
    //        tempText.transform.SetParent(panelResult.transform, false);
    //    }
    //}
    /// <summary>
    /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //метод подсчета Влад
    //private void Calculate(float a, float b, float dx)
    //{     
    //    int k = 0;
    //    //обновление списка
    //    foreach (Transform child in panelResult.transform)
    //    {
    //        GameObject.Destroy(child.gameObject);
    //        k = 0;
    //    }
    //    //расчет функции
    //    for (float i = a; i <= b; i = i + dx)
    //    {
    //        k++;
    //        double y = 0;
    //        if (i < (a - 1))
    //        {
    //            y = a * i - Math.Log((a - Math.Sqrt(i)));
    //        }
    //        if (i >= (a - 1))
    //        {
    //            y = a * Math.Sqrt(i) + Math.Log(a + Math.Pow(i, 2));
    //        }
    //        TextMeshProUGUI tempText = Instantiate(textResult);
    //        y = Math.Round(y, 5);
    //        tempText.text = k +"    x = " + i + "   y = " + y.ToString();
    //        tempText.transform.SetParent(panelResult.transform, false);
    //    }
    //}
    //метод подсчета Саша
    private void Calculate(float a, float b, float dx, float t)
    {
        int k = 0;
        //обновление списка
        foreach (Transform child in panelResult.transform)
        {
            GameObject.Destroy(child.gameObject);
            k = 0;
        }
        //расчет функции
        for (float i = a; i <= b; i = i + dx)
        {
            k++;
            double y = 0;
            if (i < t)
            {
                y = a * Math.Pow(t, 2) + Math.Log(a * i + t);
            }
            if (i >= t)
            {
                y = Math.Pow(Math.E, a) - i;
            }
            TextMeshProUGUI tempText = Instantiate(textResult);
            y = Math.Round(y, 5);
            tempText.text = k + "    x = " + i + "   y = " + y.ToString();
            tempText.transform.SetParent(panelResult.transform, false);
        }
    }

    //смена цвета экрана
    private void Update()
    {
        if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            inputPanel.GetComponent<Image>().color = new Color32(255, 200, 0, 255);
            outputPanel.GetComponent<Image>().color = new Color32(255, 200, 0, 255);
        }
        else if (Screen.orientation == ScreenOrientation.Portrait)
        {
            inputPanel.GetComponent<Image>().color = new Color32(255, 255, 0, 255);
            outputPanel.GetComponent<Image>().color = new Color32(255, 255, 0, 255);
        }
    }

}
