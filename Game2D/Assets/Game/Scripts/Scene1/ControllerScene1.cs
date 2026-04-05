using UnityEngine;
using TMPro;

public class ControllerScene1 : MonoBehaviour
{
    public Timer tiempoScene;

    public TextMeshProUGUI txtCountVApple;
    public TextMeshProUGUI txtCountVOrange;

    void Start() { }

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
}