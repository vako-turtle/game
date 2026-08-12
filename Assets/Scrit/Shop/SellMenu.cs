using UnityEngine;
using TMPro;

public class SellMenu : MonoBehaviour
{


    public static SellMenu Instance;

    public TextMeshProUGUI preMultiplierText;
    public TextMeshProUGUI multiplierText;
    public TextMeshProUGUI totalText;

    private int totalPreMultiplier;

    private void Awake()
    {
        Instance = this;
    }

    public void Refresh()
    {
        if (PlayerStats.Instance == null || InventoryManager.Instance == null)
            return;

        totalPreMultiplier = 0;

        foreach (var slot in InventoryManager.Instance.slots)
        {
            if (slot == null) continue;
            if (slot.IsEmpty()) continue;
            if (slot.item.sellPrice <= 0) continue;

            totalPreMultiplier += slot.amount * slot.item.sellPrice;
        }

        float multiplier = PlayerStats.Instance.sellMultiplier;
        int finalTotal = Mathf.RoundToInt(totalPreMultiplier * multiplier);

        preMultiplierText.text = totalPreMultiplier + "G";
        multiplierText.text = multiplier + "X";
        totalText.text = finalTotal + "G";
    }

    public void SellAll()
    {
        Refresh();

        float multiplier = PlayerStats.Instance.sellMultiplier;
        int finalTotal = Mathf.RoundToInt(totalPreMultiplier * multiplier);

        if (finalTotal <= 0)
            return;

        PlayerMoney.Instance.AddMoney(finalTotal);

        foreach (var slot in InventoryManager.Instance.slots)
        {
            if (slot == null) continue;
            if (!slot.IsEmpty() && slot.item.sellPrice > 0)
            {
                slot.item = null;
                slot.amount = 0;
            }
        }

        InventoryManager.Instance.OnInventoryChanged?.Invoke();
        Refresh();
    }
}
