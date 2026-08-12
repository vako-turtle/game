using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Detales : MonoBehaviour
{
    public static Detales Instance;

    public GameObject panel;
    public Image icon;
    public TextMeshProUGUI description;

    private void Awake()
    {
        Instance = this;
        panel.SetActive(false);
    }

    public void Show(ItemData item)
    {
        panel.SetActive(true);

        icon.sprite = item.icon;
        description.text = item.description;
    }

    public void Hide()
    {
        panel.SetActive(false);
    }









    //public static Detales Instance;

    //public GameObject panel;
    //public Image icon;

    //public TextMeshProUGUI description;

    //private void Awake()
    //{
    //    Instance = this;
    //    Hide();
    //}

    //public void Show(ItemData item)
    //{
    //    panel.SetActive(true);

    //    icon.sprite = item.icon;

    //    description.text = item.description;
    //}

    //public void Hide()
    //{
    //    panel.SetActive(false);
    //}









//public GameObject panel;
////public Image icon;
////public TextMeshProUGUI itemName;
////public TextMeshProUGUI description;

//private void Awake()
//{
//    //Instance = this;
//    //panel.SetActive(false);
//}

//public void Show(ItemData item)
//{
//    panel.SetActive(true);

//    //icon.sprite = item.icon;
//    //itemName.text = item.itemName;
//    //description.text = item.description;
//}

//public void Hide()
//{
//    //panel.SetActive(false);
//}


}
