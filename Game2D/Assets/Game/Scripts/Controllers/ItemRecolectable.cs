using UnityEngine;

public class ItemRecolectable : MonoBehaviour
{
    [SerializeField] private ItemData _itemData;
    [SerializeField] private AudioClip _collectSound;
    [SerializeField] private AudioSource _audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        if (_itemData == null || GameManager.Instance == null) return;

        GameManager.Instance.AddItem(_itemData);

        MissionManager missionMgr = Object.FindFirstObjectByType<MissionManager>();
        if (missionMgr != null)
        {
            missionMgr.OnFruitCollected(_itemData.itemType.ToString(), "Comun");
        }

        if (_collectSound != null)
            AudioSource.PlayClipAtPoint(_collectSound, transform.position);

        AudioSource.PlayClipAtPoint(_collectSound, transform.position);

        Debug.Log($"Collected item: {_itemData.itemType.ToString()}");
        Destroy(gameObject);
    }

    void Start() { }

    void Update() { }
}