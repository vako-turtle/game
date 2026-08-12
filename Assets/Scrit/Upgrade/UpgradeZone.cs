using UnityEngine;

public class UpgradeZone : MonoBehaviour
{

    public GameObject sellUI;

    private bool isPlayerInside = false;
    private bool isMenuOpen = false;

    private void Update()
    {
        if (isPlayerInside && Input.GetKeyDown(KeyCode.E))
        {
            if (!isMenuOpen)
                OpenMenu();
            else
                CloseMenu();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = false;
            CloseMenu();
        }
    }

    void OpenMenu()
    {
        sellUI.SetActive(true);
        SellMenu.Instance.Refresh();

        Time.timeScale = 0f;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        isMenuOpen = true;
    }

    void CloseMenu()
    {
        sellUI.SetActive(false);

        Time.timeScale = 1f;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        isMenuOpen = false;
    }
}
