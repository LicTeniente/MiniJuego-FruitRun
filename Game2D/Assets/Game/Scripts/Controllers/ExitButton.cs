using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void Salir()
    {
        Debug.Log("Boton presionado");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}