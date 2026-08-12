using UnityEngine;
using System.Collections.Generic;
using System;


public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public int inventorySize = 20;
    public List<InventorySlot> slots = new List<InventorySlot>();

    public Action OnInventoryChanged;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        InitializeInventory();
    }

    void InitializeInventory()
    {
        slots = new List<InventorySlot>();

        for (int i = 0; i < inventorySize; i++)
        {
            slots.Add(new InventorySlot());
        }
    }

    public bool AddItem(ItemData item, int amount = 1)
    {
        if (item == null)
        {
            Debug.LogError("Trying to add NULL item to inventory");
            return false;
        }


        foreach (var slot in slots)
        {
            if (!slot.IsEmpty() &&
                slot.item.itemID == item.itemID &&
                slot.amount < item.maxStack)
            {
                int spaceLeft = item.maxStack - slot.amount;
                int addAmount = Mathf.Min(spaceLeft, amount);

                slot.amount += addAmount;
                OnInventoryChanged?.Invoke();
                return true;
            }
        }

     
        foreach (var slot in slots)
        {
            if (slot.IsEmpty())
            {
                slot.item = item;
                slot.amount = amount;
                OnInventoryChanged?.Invoke();
                return true;
            }
        }

        Debug.Log("Inventory full");
        return false;
    }

    //    public static InventoryManager Instance;

    //    public int inventorySize = 20;
    //    public List<InventorySlot> slots = new List<InventorySlot>();

    //    public Action OnInventoryChanged;

    //    private void Awake()
    //    {
    //        if (Instance != null && Instance != this)
    //        {
    //            Destroy(gameObject);
    //            return;
    //        }

    //        Instance = this;
    //        DontDestroyOnLoad(gameObject);

    //        InitializeInventory();
    //    }

    //    void InitializeInventory()
    //    {
    //        slots.Clear();
    //        for (int i = 0; i < inventorySize; i++)
    //            slots.Add(new InventorySlot());
    //    }

    //    public bool AddItem(ItemData item, int amount = 1)
    //    {
    //        foreach (var slot in slots)
    //        {
    //            if (!slot.IsEmpty() &&
    //                slot.item.itemID == item.itemID &&
    //                slot.amount < item.maxStack)
    //            {
    //                slot.amount += amount;
    //                OnInventoryChanged?.Invoke();
    //                return true;
    //            }
    //        }

    //        foreach (var slot in slots)
    //        {
    //            if (slot.IsEmpty())
    //            {
    //                slot.item = item;
    //                slot.amount = amount;
    //                OnInventoryChanged?.Invoke();
    //                return true;
    //            }
    //        }

    //        Debug.Log("inventory fyll");
    //        return false;
    //    }





}
