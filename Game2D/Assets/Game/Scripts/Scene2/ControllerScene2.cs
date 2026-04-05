using UnityEngine;

public class ControllerScene2 : MonoBehaviour
{
    public Timer tiempoScene;

    void Start()
    {
        if (GameManager.Instance != null)
            ShowTimeGameManager();
        else
            Debug.LogError("GameManager no está inicializado en Scene2");
    }

    void Update() { }

    public void ShowTimeGameManager()
    {
        Debug.Log("Tiempo que paso en escena1 " + GameManager.Instance.GlobalTime);
    }

    public void GetTimePassGM()
    {
        float timeStop = tiempoScene.StopTime;
        GameManager.Instance.TotalTime(timeStop);
    }
}