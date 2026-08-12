using UnityEngine;

public class SellZone : MonoBehaviour
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













    //    public GameObject sellUI;

    //    private void OnTriggerEnter(Collider other)
    //    {
    //        if (other.CompareTag("Player"))
    //        {
    //            sellUI.SetActive(true);
    //            SellMenu.Instance.Refresh();

    //            Time.timeScale = 0f;

    //            Cursor.lockState = CursorLockMode.None;
    //            Cursor.visible = true;
    //        }
    //    }

    //    private void OnTriggerExit(Collider other)
    //    {
    //        if (other.CompareTag("Player"))
    //        {
    //            sellUI.SetActive(false);

    //            Time.timeScale = 1f;

    //            Cursor.lockState = CursorLockMode.Locked;
    //            Cursor.visible = false;
    //        }
    //    }











    //public GameObject sellUI;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        sellUI.SetActive(true);
    //        SellMenu.Instance.Refresh();

    //        Time.timeScale = 0f; 
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        sellUI.SetActive(false);

    //        Time.timeScale = 1f; 
    //    }
    //}








    //public GameObject sellMenuUI;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        sellMenuUI.SetActive(true);
    //        Time.timeScale = 0f;
    //        Cursor.visible = true;
    //        Cursor.lockState = CursorLockMode.None;

    //        SellMenu.Instance.Refresh();
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        sellMenuUI.SetActive(false);
    //        Time.timeScale = 1f;
    //        Cursor.visible = false;
    //        Cursor.lockState = CursorLockMode.Locked;
    //    }
    //}

}
