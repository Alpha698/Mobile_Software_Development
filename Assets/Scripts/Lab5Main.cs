using UnityEngine;
using UnityEngine.UI;


public class Lab5Main : MonoBehaviour
{
    public Button addRecord;
    public GameObject containerForObject;

    private Button bttnListObj;
    // Для удобства сделаем определенный максимум для обьектов, чтоб их нельзя было создать бесконечно много
    private int countObj=0;

    private void Start()
    {
        addRecord.onClick.AddListener(CreateNewObject);
    }

    private void CreateNewObject()
    {
        // Проверка на колличество обьектов
        if (countObj < 25)
        {
            // Instantiate - Создание обьекта
            // Resources.Load - Загрузка обьекта с ресурсов
            // containerForObject.transform - Определение родительского обьекта, куда будет помещен обьект при создании
            bttnListObj = Instantiate(Resources.Load<Button>("ListButton5Lab"), containerForObject.transform);
            countObj++;
            // Получаем компонент текста в дочерних обьектах для передачи названия
            bttnListObj.gameObject.GetComponentInChildren<Text>().text = "Record " + countObj;
        }
        else
        {
            Debug.Log("Maximum count record reached!");
        }
    }
}
