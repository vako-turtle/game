using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class InventorySlotUI : MonoBehaviour, IPointerClickHandler
{
    public Image icon;
    public TextMeshProUGUI amountText;

    private int slotIndex;

    public void Setup(int index)
    {
        slotIndex = index;
    }

    public void UpdateSlot(InventorySlot slot)
    {
        if (slot == null || slot.IsEmpty())
        {
            icon.enabled = false;
            amountText.text = "";
        }
        else
        {
            icon.enabled = true;
            icon.sprite = slot.item.icon;
            amountText.text = slot.amount > 1 ? slot.amount.ToString() : "";
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (InventoryManager.Instance == null) return;

        var slot = InventoryManager.Instance.slots[slotIndex];

        if (!slot.IsEmpty() && Detales.Instance != null)
        {
            Detales.Instance.Show(slot.item);
        }
    }

    public void OnDetailsButton()
    {
        var slot = InventoryManager.Instance.slots[slotIndex];

        if (!slot.IsEmpty())
        {
            Detales.Instance.Show(slot.item);
        }
    }




    //    public Image icon;
    //    public TextMeshProUGUI amountText;

    //    private int slotIndex;

    //    public void Setup(int index)
    //    {
    //        slotIndex = index;
    //    }

    //    public void UpdateSlot(InventorySlot slot)
    //    {
    //        if (slot.IsEmpty())
    //        {
    //            icon.enabled = false;
    //            amountText.text = "";
    //        }
    //        else
    //        {
    //            icon.enabled = true;
    //            icon.sprite = slot.item.icon;
    //            amountText.text = slot.amount.ToString();
    //        }
    //    }

    //    public void OnPointerClick(PointerEventData eventData)
    //    {
    //        var slot = InventoryManager.Instance.slots[slotIndex];
    //        if (!slot.IsEmpty())
    //            Detales.Instance.Show(slot.item);
    //    }


}
