using UnityEngine;



[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
public class ItemData : ScriptableObject
{
    public int itemID;
    public string itemName;

    [TextArea]
    public string description;

    public Sprite icon;

    public int maxStack = 99;
    public int sellPrice = 1;

 

}













//using UnityEngine;


//[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
//public class ItemData : ScriptableObject
//{

//    public int itemID;
//    public string itemName;
//    [TextArea] public string description;
//    public Sprite icon;
//    public int maxStack = 99;


//}

