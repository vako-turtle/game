using UnityEngine;
using TMPro;
public class UpgradeMenu : MonoBehaviour
{

  
    public TextMeshProUGUI damageText;
    public TextMeshProUGUI multiplierText;

    public TextMeshProUGUI damagePriceText;
    public TextMeshProUGUI multiplierPriceText;

    public int damagePrice = 100;
    public int multiplierPrice = 1000;

    private void OnEnable()
    {
        RefreshUI();
    }

    void RefreshUI()
    {
        if (PlayerStats.Instance == null) return;

        damageText.text = "Current damage: " + PlayerStats.Instance.damage.ToString("F1");
        multiplierText.text = "Current multiplier: " + PlayerStats.Instance.sellMultiplier.ToString("F1");

        damagePriceText.text = "Price: " + damagePrice + "G";
        multiplierPriceText.text = "Price: " + multiplierPrice + "G";
    }

    public void UpgradeDamage()
    {
        if (!PlayerMoney.Instance.SpendMoney(damagePrice))
            return;

        PlayerStats.Instance.damage += 1f;
        damagePrice += 100;

        RefreshUI();
    }

    public void UpgradeMultiplier()
    {
        if (!PlayerMoney.Instance.SpendMoney(multiplierPrice))
            return;

        PlayerStats.Instance.sellMultiplier += 0.2f;
        multiplierPrice += 1000;

        RefreshUI();
    }

}
