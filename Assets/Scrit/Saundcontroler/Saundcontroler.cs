using UnityEngine;

public class Saundcontroler : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
  
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            audioSource.Play();
        }
    }
}
