using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryUI : MonoBehaviour
{
    public static InventoryUI Instance;

    [Header("Panel de inventario")]
    public GameObject panelInventario;

    [Header("Contadores de frutas")]
    public TextMeshProUGUI txtCountVApple;
    public TextMeshProUGUI txtCountVBananas;
    public TextMeshProUGUI txtCountVCherries;
    public TextMeshProUGUI txtCountVKiwi;
    public TextMeshProUGUI txtCountVMelon;
    public TextMeshProUGUI txtCountVOrange;
    public TextMeshProUGUI txtCountVPineapple;
    public TextMeshProUGUI txtCountVStrawberry;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        if (panelInventario != null)
            panelInventario.SetActive(false);
    }

    void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame)
            ToggleInventario();
    }

    public void ToggleInventario()
    {
        if (panelInventario == null) return;
        panelInventario.SetActive(!panelInventario.activeSelf);

        // Actualiza los datos cuando se abre
        if (panelInventario.activeSelf)
            UpdateUI();
    }

    public void UpdateUI()
    {
        if (GameManager.Instance == null) return;

        if (txtCountVApple != null) txtCountVApple.text = "x" + GameManager.Instance.TotalApple;
        if (txtCountVOrange != null) txtCountVOrange.text = "x" + GameManager.Instance.TotalOrange;
        if (txtCountVBananas != null) txtCountVBananas.text = "x" + GameManager.Instance.TotalBananas;
        if (txtCountVKiwi != null) txtCountVKiwi.text = "x" + GameManager.Instance.TotalKiwi;
        if (txtCountVCherries != null) txtCountVCherries.text = "x" + GameManager.Instance.TotalCherries;
        if (txtCountVMelon != null) txtCountVMelon.text = "x" + GameManager.Instance.TotalMelon;
        if (txtCountVPineapple != null) txtCountVPineapple.text = "x" + GameManager.Instance.TotalPineapple;
        if (txtCountVStrawberry != null) txtCountVStrawberry.text = "x" + GameManager.Instance.TotalStrawberry;
    }
}