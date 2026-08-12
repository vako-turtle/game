using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    public InventorySlotUI[] slotUIs;

    private void Start()
    {
        if (InventoryManager.Instance == null)
        {
            Debug.LogError("InventoryManager not found!");
            return;
        }

        InventoryManager.Instance.OnInventoryChanged += UpdateUI;

        for (int i = 0; i < slotUIs.Length; i++)
        {
            slotUIs[i].Setup(i);
        }

        UpdateUI();
    }

    private void OnDestroy()
    {
        if (InventoryManager.Instance != null)
            InventoryManager.Instance.OnInventoryChanged -= UpdateUI;
    }

    void UpdateUI()
    {
        if (InventoryManager.Instance == null) return;

        for (int i = 0; i < slotUIs.Length; i++)
        {
            if (i < InventoryManager.Instance.slots.Count)
            {
                slotUIs[i].UpdateSlot(
                    InventoryManager.Instance.slots[i]);
            }
        }
    }
}
