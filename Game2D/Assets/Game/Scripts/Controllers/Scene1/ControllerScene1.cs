using UnityEngine;
using TMPro;

public class ControllerScene1 : MonoBehaviour
{
    public Timer tiempoScene;

    public TextMeshProUGUI txtCountVApple;
    public TextMeshProUGUI txtCountVBananas;
    public TextMeshProUGUI txtCountVCherries;
    public TextMeshProUGUI txtCountVKiwi;
    public TextMeshProUGUI txtCountVMelon;
    public TextMeshProUGUI txtCountVOrange;
    public TextMeshProUGUI txtCountVPineapple;
    public TextMeshProUGUI txtCountVStrawberry;


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
        txtCountVApple.text = GameManager.Instance.CountApple.ToString();
        txtCountVBananas.text = GameManager.Instance.CountBananas.ToString();
        txtCountVCherries.text = GameManager.Instance.CountCherries.ToString();
        txtCountVKiwi.text = GameManager.Instance.CountKiwi.ToString();
        txtCountVMelon.text = GameManager.Instance.CountMelon.ToString();
        txtCountVOrange.text = GameManager.Instance.CountOrange.ToString();
        txtCountVPineapple.text = GameManager.Instance.CountPineapple.ToString();
        txtCountVStrawberry.text = GameManager.Instance.CountStrawberry.ToString();
    }
}   