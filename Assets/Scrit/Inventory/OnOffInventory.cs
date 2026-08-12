using UnityEngine;

public class OnOffInventory : MonoBehaviour
{


    public GameObject inventoryPanel;
    public GameObject crosshair;
    public GameObject upgraide;


    private bool isOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            isOpen = !isOpen;


            inventoryPanel.SetActive(isOpen);
            crosshair.SetActive(!isOpen);

            Cursor.visible = isOpen;
            Cursor.lockState = isOpen ? CursorLockMode.None : CursorLockMode.Locked;

            Time.timeScale = isOpen ? 0f : 1f;
        }

       
    }
}
