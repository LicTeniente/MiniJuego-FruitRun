using UnityEngine;
using TMPro;

public class SummaryScreen : MonoBehaviour
{
    [Header("Resumen de frutas")]
    public TextMeshProUGUI txtApple;
    public TextMeshProUGUI txtBananas;
    public TextMeshProUGUI txtCherries;
    public TextMeshProUGUI txtKiwi;
    public TextMeshProUGUI txtMelon;
    public TextMeshProUGUI txtOrange;
    public TextMeshProUGUI txtPineapple;
    public TextMeshProUGUI txtStrawberry;

    void Start()
    {
        if (GameManager.Instance == null) return;

        txtApple.text = "Manzanas: " + GameManager.Instance.TotalApple;
        txtOrange.text = "Naranjas: " + GameManager.Instance.TotalOrange;
        txtBananas.text = "Bananas: " + GameManager.Instance.TotalBananas;
        txtKiwi.text = "Kiwis: " + GameManager.Instance.TotalKiwi;
        txtCherries.text = "Cerezas: " + GameManager.Instance.TotalCherries;
        txtMelon.text = "Melones: " + GameManager.Instance.TotalMelon;
        txtPineapple.text = "Piñas: " + GameManager.Instance.TotalPineapple;
        txtStrawberry.text = "Fresas: " + GameManager.Instance.TotalStrawberry;
    }
}