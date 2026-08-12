using UnityEngine;

public class PlayerStats : MonoBehaviour
{


    public static PlayerStats Instance;

    public float damage = 1f;
    public float sellMultiplier = 1f;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }









    //public static PlayerStats Instance;

    //public float damage = 1f;
    //public float sellMultiplier = 1f;

    //private void Awake()
    //{
    //    Instance = this;
    //}

    //public void IncreaseDamage()
    //{
    //    damage += 0.5f;
    //}

    //public void IncreaseSellMultiplier()
    //{
    //    sellMultiplier += 1f;
    //}




    //public static PlayerStats Instance;

    //public int damageLevel = 1;
    //public int sellLevel = 1;

    //private void Awake()
    //{
    //    Instance = this;
    //}

    //public int GetDamage()
    //{
    //    return damageLevel;
    //}

    //public float GetSellMultiplier()
    //{
    //    return sellLevel;
    //}

    //public void UpgradeDamage()
    //{
    //    damageLevel++;
    //}

    //public void UpgradeSell()
    //{
    //    sellLevel++;
    //}


    //public static PlayerStats Instance;

    //[Header("Levels")]
    //public int sellLevel = 1;
    //public int damageLevel = 1;

    //[Header("Base Stats")]
    //public float baseSellMultiplier = 1f;
    //public float baseDamage = 10f;

    //private void Awake()
    //{
    //    Instance = this;
    //}

    //public float GetSellMultiplier()
    //{
    //    return baseSellMultiplier + (sellLevel - 1) * 0.2f;
    //}

    //public float GetDamage()
    //{
    //    return baseDamage + (damageLevel - 1) * 5f;
    //}

    //public void UpgradeSell()
    //{
    //    sellLevel++;
    //}

    //public void UpgradeDamage()
    //{
    //    damageLevel++;
    //}

}
