using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private float globalTime;

    //variables para sumar 
    private int totalApple;
    private int totalOrange;
    private int totalBananas;
    private int totalKiwi;
    private int totalCherries;
    private int totalMelon;
    private int totalPineapple;
    private int totalStrawberry;
    // Cantidades 
    private int countApple;
    private int countOrange;
    private int countBananas;
    private int countKiwi;
    private int countCherries;
    private int countMelon;
    private int countPineapple;
    private int countStrawberry;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Init()
    {
        if (Instance == null)
        {
            GameObject go = new GameObject("---GameManager---");
            go.AddComponent<GameManager>();
        }
    }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        globalTime = 0;
    }

    void Update()
    {

    }

    public void TotalTime(float timeScene)
    {
        globalTime += timeScene;
    }

    public void SumarItem(string itemName, int itemValue)
    {
        switch (itemName)
        {
            case "Apple":
                totalApple += itemValue;
                countApple++;
                break;
            case "Orange":
                totalOrange += itemValue;
                countOrange++;
                break;
            case "Bananas":
                totalBananas += itemValue;
                countBananas++;
                break;
            case "Kiwi":
                totalKiwi += itemValue;
                countKiwi++;
                break;
            case "Cherries":
                totalCherries += itemValue;
                countCherries++;
                break;
            case "Melon":
                totalMelon += itemValue;
                countMelon++;
                break;
            case "Pineapple":
                totalPineapple += itemValue;
                countPineapple++;
                break;
            case "Strawberry":
                totalStrawberry += itemValue;
                countStrawberry++;
                break;
        }
    }

    public float GlobalTime { get => globalTime; set => globalTime = value; }
    public int TotalApple { get => totalApple; set => totalApple = value; }
    public int TotalOrange { get => totalOrange; set => totalOrange = value; }
    public int TotalBananas { get => totalBananas; set => totalBananas = value; }
    public int TotalKiwi { get => totalKiwi; set => totalKiwi = value; }
    public int TotalCherries { get => totalCherries; set => totalCherries = value; }
    public int TotalMelon { get => totalMelon; set => totalMelon = value; }
    public int TotalPineapple { get => totalPineapple; set => totalPineapple = value; }
    public int TotalStrawberry { get => totalStrawberry; set => totalStrawberry = value; }
    public int CountApple { get => countApple; }
    public int CountOrange { get => countOrange; }
    public int CountBananas { get => countBananas; }
    public int CountKiwi { get => countKiwi; }
    public int CountCherries { get => countCherries; }
    public int CountMelon { get => countMelon; }
    public int CountPineapple { get => countPineapple; }
    public int CountStrawberry { get => countStrawberry; }

    public void Salir()
    {
        
        Application.Quit();

        
        Debug.Log("El juego se ha cerrado");
    }
}