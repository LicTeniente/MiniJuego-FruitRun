using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePortal : MonoBehaviour
{
    [SerializeField] private string SceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        MissionManager missionManager = Object.FindFirstObjectByType<MissionManager>();
        
        if (missionManager == null)
        {
            Debug.LogWarning("¡ATENCIÓN! No hay un MissionManager en esta escena. Como no hay misiones para validar, el portal te dejará pasar automáticamente.");
            SceneManager.LoadScene(SceneName);
            return;
        }

        if (!missionManager.SonTodasLasMisionesCompletadas())
        {
            Debug.Log("No puedes salir de nivel aún. ¡Te faltan misiones por completar!");
            return;
        }

        Debug.Log("¡Misiones completadas! Haciendo TP a " + SceneName);
        SceneManager.LoadScene(SceneName);
    }
}