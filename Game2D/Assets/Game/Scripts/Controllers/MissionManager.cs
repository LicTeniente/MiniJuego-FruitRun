using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class MissionManager : MonoBehaviour
{
    [Header("Configuración de la Escena")]
    [Tooltip("Escribe los IDs de las misiones que se habilitarán en esta escena (Ej: 1 o 3)")]
    public List<int> misionesIdsConfiguradas = new List<int> { 1 };

    public List<MisionData> misionesActivas = new List<MisionData>();

    // Contadores REALES de cantidad recogidas en este nivel
    private int cantidadTotal = 0;
    private int cantidadManzanas = 0;
    private int cantidadRaras = 0;
    private int cantidadPinas = 0;
    private int cantidadMelones = 0;

    void Start()
    {
        LoadMissions();
    }

    void LoadMissions()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "GameData.json");
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            GameDataWrapper data = JsonUtility.FromJson<GameDataWrapper>(json);
            if (data != null && data.misiones != null)
            {
                misionesActivas.Clear();
                foreach (var mision in data.misiones)
                {
                    if (misionesIdsConfiguradas.Contains(mision.id))
                    {
                        misionesActivas.Add(mision);
                    }
                }
                Debug.Log($"Se cargaron {misionesActivas.Count} misiones para esta escena.");
            }
        }
        else
        {
            Debug.LogError("No se encontró el archivo JSON de misiones en: " + path);
        }
    }

    // Este lo debes llamar desde el script que atrapa las frutas
    public void OnFruitCollected(string fruitName, string rareza)
    {
        cantidadTotal++;
        
        if (fruitName == "Apple") cantidadManzanas++;
        if (rareza == "Raro" || fruitName == "Cherries" || fruitName == "Kiwi" || fruitName == "Strawberry") cantidadRaras++;
        if (fruitName == "Pineapple") cantidadPinas++;
        if (fruitName == "Melon") cantidadMelones++;

        CheckMissions();
    }

    private void CheckMissions()
    {
        foreach (var mision in misionesActivas)
        {
            if (mision.isCompleted) continue;

            bool completadaAhora = false;
            switch (mision.id)
            {
                case 1:
                    if (cantidadTotal >= 5) completadaAhora = true;
                    break;
                case 2:
                    if (cantidadManzanas >= 3) completadaAhora = true;
                    break;
                case 3:
                    if (cantidadRaras >= 2) completadaAhora = true;
                    break;
                case 4:
                    if (cantidadPinas >= 1 && cantidadMelones >= 1) completadaAhora = true;
                    break;
            }

            if (completadaAhora)
            {
                mision.isCompleted = true;
                Debug.Log($"¡Misión completada!: {mision.titulo}");
            }
        }
    }

    public bool SonTodasLasMisionesCompletadas()
    {
        if (misionesActivas.Count == 0) return false;

        CheckMissions(); // Actualiza por si acaso antes de revisar

        foreach (var mision in misionesActivas)
        {
            if (!mision.isCompleted) return false;
        }

        return true;
    }
}
