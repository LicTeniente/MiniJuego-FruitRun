using UnityEngine;
using System.IO;

using System;

public class GameDataLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private string fileName = "GameData.json";
    public GameData gameData;
    private void Awake()
    {
        LoadGameData();
    }

    private void LoadGameData()
    {
        string path = Path.Combine(Application.streamingAssetsPath, fileName);
        if (!File.Exists(path))
        {
            Debug.Log($"Loading game data from: {path}" + "Error");
            return;
        }
    
        string json= File.ReadAllText(path);
        gameData= JsonUtility.FromJson<GameData>(json);
    }

    public ColeccionableData ObtenerColeccionablePorNombre(string nombre)
    {
        if (gameData == null || gameData.coleccionables == null) return null;

        for (int i = 0; i < gameData.coleccionables.Length; i++)
        {
            if (gameData.coleccionables[i].nombre == nombre)
                return gameData.coleccionables[i];
        }

        return null;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
