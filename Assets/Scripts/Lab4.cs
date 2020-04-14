using System;
using UnityEngine;
using UnityEngine.UI;
public class Lab4 : MonoBehaviour
{
    // Кнопки для перехода между окнами
    public Button showTimeButton;
    public Button showDateButton;
    public Button backButton1, backButton2;
    // Окна приложения 
    public GameObject firstPage;
    public GameObject secondPage;
    public GameObject thirdPage;
    // Текст в который будут выводится данные
    public Text timeText;
    public Text dateText;
    // Получение текущей даты и времени
    private DateTime nowDate;
    void Start()
    {
        // Добавление слушателей на кнопки
        showTimeButton.onClick.AddListener(ClickButtonTime);
        showDateButton.onClick.AddListener(ClickButtonData);
        backButton1.onClick.AddListener(ClickButtonBack);
        backButton2.onClick.AddListener(ClickButtonBack);
    }
    // Метод который будет отрабатывать каждый такт процессора и динамично обновлять наше время
    private void Update()
    {
        nowDate = DateTime.Now;
        // Вывод времени в соответсвующий обьект текста
        timeText.text = nowDate.ToLongTimeString();
        // Вывод даты в соответсвующий обьект текста
        dateText.text = nowDate.ToShortDateString();
    }

    // Методы для открытия и закрытия окон
    private void ClickButtonTime()
    {
        firstPage.SetActive(false);
        secondPage.SetActive(true);
    }
    private void ClickButtonData()
    {
        firstPage.SetActive(false);
        thirdPage.SetActive(true);
    }
    private void ClickButtonBack()
    {
        firstPage.SetActive(true);
        secondPage.SetActive(false);
        thirdPage.SetActive(false);
    }
}

