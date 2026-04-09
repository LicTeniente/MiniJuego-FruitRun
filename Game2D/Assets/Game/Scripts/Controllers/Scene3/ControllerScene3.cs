using UnityEngine;
using TMPro;

public class ControllerScene3 : MonoBehaviour
{
    public Timer tiempoScene;

    public TextMeshProUGUI txtCountVApple;
    public TextMeshProUGUI txtCountVOrange;

    void Start()
    {
        if (GameManager.Instance != null)
            ShowTimeGameManager();
        else
            Debug.LogError("GameManager no está inicializado en Scene3");
    }

    void Update()
    {
        if (GameManager.Instance == null) return;
        GetCountItems();
    }

    public void GetTimePassGM()
    {
        float timeStop = tiempoScene.StopTime;
        GameManager.Instance.TotalTime(timeStop);
    }

    public void GetCountItems()
    {
        txtCountVApple.text = GameManager.Instance.TotalApple.ToString();
        txtCountVOrange.text = GameManager.Instance.TotalOrange.ToString();
    }

    public void ShowTimeGameManager()
    {
        Debug.Log("Total de las 2 escenas \n estoy en la escena 3: " + GameManager.Instance.GlobalTime);
    }
}