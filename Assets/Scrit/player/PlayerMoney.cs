using UnityEngine;
using TMPro;


public class PlayerMoney : MonoBehaviour
{


    public static PlayerMoney Instance;

    public int money;

    public TextMeshProUGUI moneyText;  

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (moneyText != null)
            moneyText.text = money + "G";
    }

    public bool SpendMoney(int amount)
    {
        if (money < amount)
            return false;

        money -= amount;
        return true;
    }

    public void AddMoney(int amount)
    {
        money += amount;
    }
}
