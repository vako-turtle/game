using UnityEngine;


public class Drops : MonoBehaviour
{
    [Range(0f, 100f)]
    public float itemDropChance = 0.5f;

    public ItemData[] possibleItems;
   
    public void DropResources()
    {
        if (possibleItems == null || possibleItems.Length == 0)
            return;

        if (Random.value > itemDropChance)
            return;

        int index = Random.Range(0, possibleItems.Length);
        ItemData item = possibleItems[index];

        InventoryManager.Instance.AddItem(item, 1);
    }







    //[Range(0f, 1f)]
    //public float itemDropChance = 0.5f;

    //public ItemData[] possibleItems;

    //public void DropResources()
    //{
    //    if (possibleItems == null || possibleItems.Length == 0)
    //        return;

    //    if (Random.value > itemDropChance)
    //        return;

    //    int index = Random.Range(0, possibleItems.Length);
    //    ItemData item = possibleItems[index];

    //    if (InventoryManager.Instance == null)
    //    {
    //        Debug.LogError("InventoryManager.Instance == null");
    //        return;
    //    }

    //    bool added = InventoryManager.Instance.AddItem(item, 1);

    //    if (added)
    //        Debug.Log($"Drops: {item.itemName}");
    //    else
    //        Debug.Log("full Inventory");
    

        //private Health health;

        //void Start()
        //{
        //    health = GetComponent<Health>();
        //}

        //public void DropResources()
        //{
        //    if (health == null) return;

        //    if (health.possibleItems == null || health.possibleItems.Length == 0)
        //        return;

        //    if (Random.value < health.itemDropChance)
        //    {
        //        int index = Random.Range(0, health.possibleItems.Length);
        //        ItemData item = health.possibleItems[index];

        //        if (InventoryManager.Instance == null)
        //        {
        //            Debug.LogError("InventoryManager.Instance == null");
        //            return;
        //        }

        //        InventoryManager.Instance.AddItem(item, 1);
        //    Debug.Log($"Drop item: {item.itemID}");
        //    Debug.Log($"Drop item: {item.itemName}");
        //    Debug.Log($"Drop item: {item.description}");
        //}
    //}
    



}
