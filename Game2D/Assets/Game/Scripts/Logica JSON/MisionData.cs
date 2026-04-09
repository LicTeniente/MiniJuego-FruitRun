using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class MisionData
{ 
    public int id;
    public string titulo;
    public string descripcion;
    public bool isCompleted;
}

[System.Serializable]
public class GameDataWrapper
{
    public List<MisionData> misiones;
}
